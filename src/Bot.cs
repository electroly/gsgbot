using System;
using System.Linq;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Events;

namespace GsgBot
{
    public sealed class TwitchMessage
    {
        public string Username;
        public string Message;
    }

    public static class Bot
    {
        public static string TwitchUsername { get; set; }
        public static string TwitchToken { get; set; }
        public static string Streamer { get; set; }
        public static Setup Setup { get; set; } = new();
        public static TwitchClient Client { get; set; }
        public static event Action<string> LogReceived;
        public static event EventHandler<TwitchMessage> MessageReceived;

        public static void Connect()
        {
            if (Client != null)
                throw new Exception("Already connected to Twitch!");

            try
            {
                ConnectionCredentials credentials = new(TwitchUsername, TwitchToken, capabilities: new());
                Client = new();
                Client.OnLog += Client_OnLog;
                Client.OnJoinedChannel += Client_OnJoinedChannel;
                Client.OnMessageReceived += Client_OnMessageReceived;
                Client.OnConnected += Client_OnConnected;
                Client.OnDisconnected += Client_OnDisconnected;
                Client.OnError += Client_OnError;
                Client.OnConnectionError += Client_OnConnectionError;
                Client.OnNoPermissionError += Client_OnNoPermissionError;
                Client.Initialize(credentials, Streamer.ToLowerInvariant());
                Client.Connect();
            }
            catch
            {
                Client = null;
                throw;
            }
        }

        private static void Client_OnNoPermissionError(object sender, EventArgs e)
        {
            Log("NoPermissionError!");
        }

        private static void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            Log($"ConnectionError! {e.Error?.Message ?? ""}");
        }

        private static void Client_OnError(object sender, OnErrorEventArgs e)
        {
            Log($"Error! {e.Exception.Message}");
        }

        private static void Client_OnDisconnected(object sender, OnDisconnectedEventArgs e)
        {
            Log("Disconnected from Twitch chat.");
        }

        private static void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            Log($"Joined channel {e.Channel}.");
        }

        private static void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            Log("Connected to Twitch chat.");
        }

        private static void Client_OnLog(object sender, OnLogArgs e)
        {
            Log(e.Data);
        }

        private static void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            Log($"<{e.ChatMessage.Username}> {e.ChatMessage.Message}");
            try
            {
                MessageReceived?.Invoke(null, new TwitchMessage { Message = e.ChatMessage.Message, Username = e.ChatMessage.Username });
            }
            catch (Exception ex)
            {
                Log("ERROR: " + ex.Message);
            }
        }

        public static void Disconnect()
        {
            if (Client == null)
                throw new Exception("Not connected!");

            try
            {
                Client.Disconnect();
            }
            finally
            {
                Client = null;
            }
        }

        public static void FakeIncomingMessage(string user, string message)
        {
            Log($"FAKE: <{user}> {message}");
            try
            {
                MessageReceived?.Invoke(null, new TwitchMessage { Message = message, Username = user });
            }
            catch (Exception ex)
            {
                Log("ERROR: " + ex.Message);
            }
        }

        public static void Say(string message)
        {
            if (Client == null)
            {
                Log($"<Me> {message}");
                return;
            }

            try
            {
                Client.SendMessage(Client.JoinedChannels.Single(), message);
            }
            catch (Exception ex)
            {
                Log($"Failed to send message! {ex.Message}");
            }
        }

        public static void Whisper(string user, string message)
        {
            if (Client == null)
            {
                Log($"Whisper to {user}: {message}");
                return;
            }

            try
            {
                Client.SendWhisper(user, message);
            }
            catch (Exception ex)
            {
                Log($"Failed to send whisper to {user}! {ex.Message}");
            }
        }

        public static void Log(string message)
        {
            LogReceived?.Invoke(message);
        }
    }
}

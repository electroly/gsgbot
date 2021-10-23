
namespace GsgBot
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._twitchGroup = new System.Windows.Forms.GroupBox();
            this._twitchTable = new System.Windows.Forms.TableLayoutPanel();
            this._streamerText = new System.Windows.Forms.TextBox();
            this._streamerLabel = new System.Windows.Forms.Label();
            this._tokenText = new System.Windows.Forms.TextBox();
            this._tokenLabel = new System.Windows.Forms.Label();
            this._usernameLabel = new System.Windows.Forms.Label();
            this._usernameText = new System.Windows.Forms.TextBox();
            this._loginLink = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this._connectTwitchButton = new System.Windows.Forms.Button();
            this._disconnectTwitchButton = new System.Windows.Forms.Button();
            this._gamesGroup = new System.Windows.Forms.GroupBox();
            this._gamesTable = new System.Windows.Forms.TableLayoutPanel();
            this._gamesToolbarFlow = new System.Windows.Forms.FlowLayoutPanel();
            this._newGameButton = new System.Windows.Forms.Button();
            this._editGameButton = new System.Windows.Forms.Button();
            this._deleteGameButton = new System.Windows.Forms.Button();
            this._gamesList = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._playGameButton = new System.Windows.Forms.Button();
            this._logGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._logList = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this._simulateChatMessageButton = new System.Windows.Forms.Button();
            this._sendMessageButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._toolbarFlow = new System.Windows.Forms.FlowLayoutPanel();
            this._openSetupFileButton = new System.Windows.Forms.Button();
            this._saveSetupFileButton = new System.Windows.Forms.Button();
            this._botStatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this._twitchGroup.SuspendLayout();
            this._twitchTable.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this._gamesGroup.SuspendLayout();
            this._gamesTable.SuspendLayout();
            this._gamesToolbarFlow.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this._logGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this._toolbarFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this._twitchGroup, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._gamesGroup, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._logGroup, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1528, 764);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // _twitchGroup
            // 
            this._twitchGroup.AutoSize = true;
            this._twitchGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._twitchGroup.Controls.Add(this._twitchTable);
            this._twitchGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this._twitchGroup.Location = new System.Drawing.Point(13, 13);
            this._twitchGroup.Name = "_twitchGroup";
            this._twitchGroup.Size = new System.Drawing.Size(748, 262);
            this._twitchGroup.TabIndex = 0;
            this._twitchGroup.TabStop = false;
            this._twitchGroup.Text = "Twitch";
            // 
            // _twitchTable
            // 
            this._twitchTable.AutoSize = true;
            this._twitchTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._twitchTable.ColumnCount = 2;
            this._twitchTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._twitchTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._twitchTable.Controls.Add(this._streamerText, 0, 3);
            this._twitchTable.Controls.Add(this._streamerLabel, 0, 3);
            this._twitchTable.Controls.Add(this._tokenText, 1, 2);
            this._twitchTable.Controls.Add(this._tokenLabel, 0, 2);
            this._twitchTable.Controls.Add(this._usernameLabel, 0, 1);
            this._twitchTable.Controls.Add(this._usernameText, 1, 1);
            this._twitchTable.Controls.Add(this._loginLink, 1, 0);
            this._twitchTable.Controls.Add(this.flowLayoutPanel2, 1, 4);
            this._twitchTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._twitchTable.Location = new System.Drawing.Point(3, 27);
            this._twitchTable.Name = "_twitchTable";
            this._twitchTable.RowCount = 5;
            this._twitchTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._twitchTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._twitchTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._twitchTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._twitchTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._twitchTable.Size = new System.Drawing.Size(742, 232);
            this._twitchTable.TabIndex = 0;
            // 
            // _streamerText
            // 
            this._streamerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._streamerText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._streamerText.Location = new System.Drawing.Point(157, 133);
            this._streamerText.Name = "_streamerText";
            this._streamerText.Size = new System.Drawing.Size(582, 39);
            this._streamerText.TabIndex = 5;
            // 
            // _streamerLabel
            // 
            this._streamerLabel.AutoSize = true;
            this._streamerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._streamerLabel.Location = new System.Drawing.Point(3, 130);
            this._streamerLabel.Name = "_streamerLabel";
            this._streamerLabel.Size = new System.Drawing.Size(86, 45);
            this._streamerLabel.TabIndex = 4;
            this._streamerLabel.Text = "&Streamer:";
            this._streamerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _tokenText
            // 
            this._tokenText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tokenText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tokenText.Location = new System.Drawing.Point(157, 88);
            this._tokenText.Name = "_tokenText";
            this._tokenText.PasswordChar = '*';
            this._tokenText.Size = new System.Drawing.Size(582, 39);
            this._tokenText.TabIndex = 3;
            this._tokenText.TextChanged += new System.EventHandler(this.TokenText_TextChanged);
            // 
            // _tokenLabel
            // 
            this._tokenLabel.AutoSize = true;
            this._tokenLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._tokenLabel.Location = new System.Drawing.Point(3, 85);
            this._tokenLabel.Name = "_tokenLabel";
            this._tokenLabel.Size = new System.Drawing.Size(148, 45);
            this._tokenLabel.TabIndex = 2;
            this._tokenLabel.Text = "Bot &access token:";
            this._tokenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _usernameLabel
            // 
            this._usernameLabel.AutoSize = true;
            this._usernameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._usernameLabel.Location = new System.Drawing.Point(3, 40);
            this._usernameLabel.Name = "_usernameLabel";
            this._usernameLabel.Size = new System.Drawing.Size(125, 45);
            this._usernameLabel.TabIndex = 0;
            this._usernameLabel.Text = "Bot &username:";
            this._usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _usernameText
            // 
            this._usernameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._usernameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._usernameText.Location = new System.Drawing.Point(157, 43);
            this._usernameText.Name = "_usernameText";
            this._usernameText.Size = new System.Drawing.Size(582, 39);
            this._usernameText.TabIndex = 1;
            this._usernameText.TextChanged += new System.EventHandler(this.UsernameText_TextChanged);
            // 
            // _loginLink
            // 
            this._loginLink.AutoSize = true;
            this._loginLink.Location = new System.Drawing.Point(157, 0);
            this._loginLink.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this._loginLink.Name = "_loginLink";
            this._loginLink.Size = new System.Drawing.Size(473, 25);
            this._loginLink.TabIndex = 5;
            this._loginLink.TabStop = true;
            this._loginLink.Text = "Click here to get the \"oauth:\" access token for the bot user";
            this._loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this._connectTwitchButton);
            this.flowLayoutPanel2.Controls.Add(this._disconnectTwitchButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(157, 178);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(392, 51);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // _connectTwitchButton
            // 
            this._connectTwitchButton.AutoSize = true;
            this._connectTwitchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._connectTwitchButton.Location = new System.Drawing.Point(3, 3);
            this._connectTwitchButton.Name = "_connectTwitchButton";
            this._connectTwitchButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._connectTwitchButton.Size = new System.Drawing.Size(231, 45);
            this._connectTwitchButton.TabIndex = 6;
            this._connectTwitchButton.Text = "⚡ Connect to Twitch";
            this._connectTwitchButton.UseVisualStyleBackColor = true;
            this._connectTwitchButton.Click += new System.EventHandler(this.ConnectTwitchButton_Click);
            // 
            // _disconnectTwitchButton
            // 
            this._disconnectTwitchButton.AutoSize = true;
            this._disconnectTwitchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._disconnectTwitchButton.Enabled = false;
            this._disconnectTwitchButton.Location = new System.Drawing.Point(240, 3);
            this._disconnectTwitchButton.Name = "_disconnectTwitchButton";
            this._disconnectTwitchButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._disconnectTwitchButton.Size = new System.Drawing.Size(149, 45);
            this._disconnectTwitchButton.TabIndex = 7;
            this._disconnectTwitchButton.Text = "Disconnect";
            this._disconnectTwitchButton.UseVisualStyleBackColor = true;
            this._disconnectTwitchButton.Click += new System.EventHandler(this.DisconnectTwitchButton_Click);
            // 
            // _gamesGroup
            // 
            this._gamesGroup.Controls.Add(this._gamesTable);
            this._gamesGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gamesGroup.Location = new System.Drawing.Point(767, 13);
            this._gamesGroup.Name = "_gamesGroup";
            this.tableLayoutPanel2.SetRowSpan(this._gamesGroup, 2);
            this._gamesGroup.Size = new System.Drawing.Size(748, 738);
            this._gamesGroup.TabIndex = 1;
            this._gamesGroup.TabStop = false;
            this._gamesGroup.Text = "Games";
            // 
            // _gamesTable
            // 
            this._gamesTable.ColumnCount = 2;
            this._gamesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._gamesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._gamesTable.Controls.Add(this._gamesToolbarFlow, 0, 0);
            this._gamesTable.Controls.Add(this._gamesList, 0, 1);
            this._gamesTable.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this._gamesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gamesTable.Location = new System.Drawing.Point(3, 27);
            this._gamesTable.Name = "_gamesTable";
            this._gamesTable.RowCount = 2;
            this._gamesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._gamesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._gamesTable.Size = new System.Drawing.Size(742, 708);
            this._gamesTable.TabIndex = 0;
            // 
            // _gamesToolbarFlow
            // 
            this._gamesToolbarFlow.AutoSize = true;
            this._gamesToolbarFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._gamesToolbarFlow.Controls.Add(this._newGameButton);
            this._gamesToolbarFlow.Controls.Add(this._editGameButton);
            this._gamesToolbarFlow.Controls.Add(this._deleteGameButton);
            this._gamesToolbarFlow.Location = new System.Drawing.Point(3, 3);
            this._gamesToolbarFlow.Name = "_gamesToolbarFlow";
            this._gamesToolbarFlow.Size = new System.Drawing.Size(471, 51);
            this._gamesToolbarFlow.TabIndex = 0;
            // 
            // _newGameButton
            // 
            this._newGameButton.AutoSize = true;
            this._newGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._newGameButton.Location = new System.Drawing.Point(3, 3);
            this._newGameButton.Name = "_newGameButton";
            this._newGameButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._newGameButton.Size = new System.Drawing.Size(189, 45);
            this._newGameButton.TabIndex = 5;
            this._newGameButton.Text = "➕ &New game...";
            this._newGameButton.UseVisualStyleBackColor = true;
            this._newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // _editGameButton
            // 
            this._editGameButton.AutoSize = true;
            this._editGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._editGameButton.Enabled = false;
            this._editGameButton.Location = new System.Drawing.Point(198, 3);
            this._editGameButton.Name = "_editGameButton";
            this._editGameButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._editGameButton.Size = new System.Drawing.Size(122, 45);
            this._editGameButton.TabIndex = 6;
            this._editGameButton.Text = "✏️ Edit";
            this._editGameButton.UseVisualStyleBackColor = true;
            this._editGameButton.Click += new System.EventHandler(this.EditGameButton_Click);
            // 
            // _deleteGameButton
            // 
            this._deleteGameButton.AutoSize = true;
            this._deleteGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._deleteGameButton.Enabled = false;
            this._deleteGameButton.Location = new System.Drawing.Point(326, 3);
            this._deleteGameButton.Name = "_deleteGameButton";
            this._deleteGameButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._deleteGameButton.Size = new System.Drawing.Size(142, 45);
            this._deleteGameButton.TabIndex = 7;
            this._deleteGameButton.Text = "❌ Delete";
            this._deleteGameButton.UseVisualStyleBackColor = true;
            this._deleteGameButton.Click += new System.EventHandler(this.DeleteGameButton_Click);
            // 
            // _gamesList
            // 
            this._gamesTable.SetColumnSpan(this._gamesList, 2);
            this._gamesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gamesList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._gamesList.FormattingEnabled = true;
            this._gamesList.IntegralHeight = false;
            this._gamesList.ItemHeight = 32;
            this._gamesList.Location = new System.Drawing.Point(3, 60);
            this._gamesList.Name = "_gamesList";
            this._gamesList.ScrollAlwaysVisible = true;
            this._gamesList.Size = new System.Drawing.Size(736, 645);
            this._gamesList.TabIndex = 1;
            this._gamesList.SelectedIndexChanged += new System.EventHandler(this.GamesList_SelectedIndexChanged);
            this._gamesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GamesList_MouseDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._playGameButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(568, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(171, 51);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // _playGameButton
            // 
            this._playGameButton.AutoSize = true;
            this._playGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._playGameButton.Enabled = false;
            this._playGameButton.Location = new System.Drawing.Point(3, 3);
            this._playGameButton.Name = "_playGameButton";
            this._playGameButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._playGameButton.Size = new System.Drawing.Size(165, 45);
            this._playGameButton.TabIndex = 5;
            this._playGameButton.Text = "▶️ &Play game";
            this._playGameButton.UseVisualStyleBackColor = true;
            this._playGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // _logGroup
            // 
            this._logGroup.Controls.Add(this.tableLayoutPanel1);
            this._logGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this._logGroup.Location = new System.Drawing.Point(13, 281);
            this._logGroup.Name = "_logGroup";
            this._logGroup.Size = new System.Drawing.Size(748, 470);
            this._logGroup.TabIndex = 2;
            this._logGroup.TabStop = false;
            this._logGroup.Text = "Log";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._logList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 440);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _logList
            // 
            this._logList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._logList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._logList.IntegralHeight = false;
            this._logList.ItemHeight = 32;
            this._logList.Location = new System.Drawing.Point(3, 60);
            this._logList.Name = "_logList";
            this._logList.ScrollAlwaysVisible = true;
            this._logList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this._logList.Size = new System.Drawing.Size(736, 377);
            this._logList.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this._simulateChatMessageButton);
            this.flowLayoutPanel3.Controls.Add(this._sendMessageButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(557, 51);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // _simulateChatMessageButton
            // 
            this._simulateChatMessageButton.AutoSize = true;
            this._simulateChatMessageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._simulateChatMessageButton.Location = new System.Drawing.Point(3, 3);
            this._simulateChatMessageButton.Name = "_simulateChatMessageButton";
            this._simulateChatMessageButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._simulateChatMessageButton.Size = new System.Drawing.Size(301, 45);
            this._simulateChatMessageButton.TabIndex = 8;
            this._simulateChatMessageButton.Text = "Fake incoming chat message...";
            this._simulateChatMessageButton.UseVisualStyleBackColor = true;
            this._simulateChatMessageButton.Click += new System.EventHandler(this.SimulateChatMessageButton_Click);
            // 
            // _sendMessageButton
            // 
            this._sendMessageButton.AutoSize = true;
            this._sendMessageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._sendMessageButton.Location = new System.Drawing.Point(310, 3);
            this._sendMessageButton.Name = "_sendMessageButton";
            this._sendMessageButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._sendMessageButton.Size = new System.Drawing.Size(244, 45);
            this._sendMessageButton.TabIndex = 9;
            this._sendMessageButton.Text = "Send message as bot...";
            this._sendMessageButton.UseVisualStyleBackColor = true;
            this._sendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 815);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1528, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(639, 25);
            this.toolStripStatusLabel1.Text = "❶ Get access token   ❷ Connect to Twitch   ❸ Double-click a game to play it";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _toolbarFlow
            // 
            this._toolbarFlow.AutoSize = true;
            this._toolbarFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._toolbarFlow.Controls.Add(this._openSetupFileButton);
            this._toolbarFlow.Controls.Add(this._saveSetupFileButton);
            this._toolbarFlow.Controls.Add(this._botStatusLabel);
            this._toolbarFlow.Dock = System.Windows.Forms.DockStyle.Top;
            this._toolbarFlow.Location = new System.Drawing.Point(0, 0);
            this._toolbarFlow.Name = "_toolbarFlow";
            this._toolbarFlow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._toolbarFlow.Size = new System.Drawing.Size(1528, 51);
            this._toolbarFlow.TabIndex = 2;
            // 
            // _openSetupFileButton
            // 
            this._openSetupFileButton.AutoSize = true;
            this._openSetupFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._openSetupFileButton.Location = new System.Drawing.Point(13, 3);
            this._openSetupFileButton.Name = "_openSetupFileButton";
            this._openSetupFileButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._openSetupFileButton.Size = new System.Drawing.Size(224, 45);
            this._openSetupFileButton.TabIndex = 6;
            this._openSetupFileButton.Text = "📁 &Open setup file...";
            this._openSetupFileButton.UseVisualStyleBackColor = true;
            this._openSetupFileButton.Click += new System.EventHandler(this.OpenSetupFileButton_Click);
            // 
            // _saveSetupFileButton
            // 
            this._saveSetupFileButton.AutoSize = true;
            this._saveSetupFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._saveSetupFileButton.Location = new System.Drawing.Point(243, 3);
            this._saveSetupFileButton.Name = "_saveSetupFileButton";
            this._saveSetupFileButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._saveSetupFileButton.Size = new System.Drawing.Size(204, 45);
            this._saveSetupFileButton.TabIndex = 7;
            this._saveSetupFileButton.Text = "💾 Save setup file";
            this._saveSetupFileButton.UseVisualStyleBackColor = true;
            this._saveSetupFileButton.Click += new System.EventHandler(this.SaveSetupFileButton_Click);
            // 
            // _botStatusLabel
            // 
            this._botStatusLabel.AutoSize = true;
            this._botStatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._botStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._botStatusLabel.ForeColor = System.Drawing.Color.Red;
            this._botStatusLabel.Location = new System.Drawing.Point(453, 0);
            this._botStatusLabel.Name = "_botStatusLabel";
            this._botStatusLabel.Size = new System.Drawing.Size(236, 51);
            this._botStatusLabel.TabIndex = 8;
            this._botStatusLabel.Text = "Bot status: OFFLINE";
            this._botStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1528, 847);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._toolbarFlow);
            this.MinimumSize = new System.Drawing.Size(822, 903);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSGBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this._twitchGroup.ResumeLayout(false);
            this._twitchGroup.PerformLayout();
            this._twitchTable.ResumeLayout(false);
            this._twitchTable.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this._gamesGroup.ResumeLayout(false);
            this._gamesTable.ResumeLayout(false);
            this._gamesTable.PerformLayout();
            this._gamesToolbarFlow.ResumeLayout(false);
            this._gamesToolbarFlow.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this._logGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this._toolbarFlow.ResumeLayout(false);
            this._toolbarFlow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel _twitchTable;
        private System.Windows.Forms.Label _usernameLabel;
        private System.Windows.Forms.TextBox _usernameText;
        private System.Windows.Forms.TextBox _tokenText;
        private System.Windows.Forms.Label _tokenLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox _twitchGroup;
        private System.Windows.Forms.GroupBox _gamesGroup;
        private System.Windows.Forms.TableLayoutPanel _gamesTable;
        private System.Windows.Forms.FlowLayoutPanel _gamesToolbarFlow;
        private System.Windows.Forms.Button _newGameButton;
        private System.Windows.Forms.Button _editGameButton;
        private System.Windows.Forms.Button _deleteGameButton;
        private System.Windows.Forms.ListBox _gamesList;
        private System.Windows.Forms.FlowLayoutPanel _toolbarFlow;
        private System.Windows.Forms.Button _openSetupFileButton;
        private System.Windows.Forms.Button _saveSetupFileButton;
        private System.Windows.Forms.LinkLabel _loginLink;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _playGameButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button _connectTwitchButton;
        private System.Windows.Forms.Button _disconnectTwitchButton;
        private System.Windows.Forms.Label _botStatusLabel;
        private System.Windows.Forms.GroupBox _logGroup;
        private System.Windows.Forms.ListBox _logList;
        private System.Windows.Forms.TextBox _streamerText;
        private System.Windows.Forms.Label _streamerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button _simulateChatMessageButton;
        private System.Windows.Forms.Button _sendMessageButton;
    }
}



namespace GsgBot
{
    partial class PollGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._votesList = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._startGuessButton = new System.Windows.Forms.Button();
            this._stopGuessButton = new System.Windows.Forms.Button();
            this._guessTimeLabel = new System.Windows.Forms.Label();
            this._guessTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._closeButton = new System.Windows.Forms.Button();
            this._helpLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 25);
            this.toolStripStatusLabel1.Text = "Game: Poll";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(13, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 590);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Votes";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this._votesList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(771, 560);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _votesList
            // 
            this._votesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._votesList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._votesList.FormattingEnabled = true;
            this._votesList.IntegralHeight = false;
            this._votesList.ItemHeight = 30;
            this._votesList.Location = new System.Drawing.Point(3, 60);
            this._votesList.MultiColumn = true;
            this._votesList.Name = "_votesList";
            this._votesList.ScrollAlwaysVisible = true;
            this._votesList.Size = new System.Drawing.Size(765, 497);
            this._votesList.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._startGuessButton);
            this.flowLayoutPanel1.Controls.Add(this._stopGuessButton);
            this.flowLayoutPanel1.Controls.Add(this._guessTimeLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(599, 51);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // _startGuessButton
            // 
            this._startGuessButton.AutoSize = true;
            this._startGuessButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._startGuessButton.Location = new System.Drawing.Point(3, 3);
            this._startGuessButton.Name = "_startGuessButton";
            this._startGuessButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._startGuessButton.Size = new System.Drawing.Size(245, 45);
            this._startGuessButton.TabIndex = 0;
            this._startGuessButton.Text = "▶ START voting period";
            this._startGuessButton.UseVisualStyleBackColor = true;
            this._startGuessButton.Click += new System.EventHandler(this.StartGuessButton_Click);
            // 
            // _stopGuessButton
            // 
            this._stopGuessButton.AutoSize = true;
            this._stopGuessButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._stopGuessButton.Enabled = false;
            this._stopGuessButton.Location = new System.Drawing.Point(254, 3);
            this._stopGuessButton.Name = "_stopGuessButton";
            this._stopGuessButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._stopGuessButton.Size = new System.Drawing.Size(247, 45);
            this._stopGuessButton.TabIndex = 2;
            this._stopGuessButton.Text = "🛑 STOP voting period";
            this._stopGuessButton.UseVisualStyleBackColor = true;
            this._stopGuessButton.Click += new System.EventHandler(this.StopGuessButton_Click);
            // 
            // _guessTimeLabel
            // 
            this._guessTimeLabel.AutoSize = true;
            this._guessTimeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._guessTimeLabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._guessTimeLabel.Location = new System.Drawing.Point(507, 0);
            this._guessTimeLabel.Name = "_guessTimeLabel";
            this._guessTimeLabel.Size = new System.Drawing.Size(89, 51);
            this._guessTimeLabel.TabIndex = 1;
            this._guessTimeLabel.Text = "-:--";
            this._guessTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _closeButton
            // 
            this._closeButton.AutoSize = true;
            this._closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._closeButton.Location = new System.Drawing.Point(685, 653);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._closeButton.Size = new System.Drawing.Size(105, 45);
            this._closeButton.TabIndex = 4;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // _helpLabel
            // 
            this._helpLabel.AutoSize = true;
            this._helpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._helpLabel.ForeColor = System.Drawing.Color.Blue;
            this._helpLabel.Location = new System.Drawing.Point(13, 10);
            this._helpLabel.Name = "_helpLabel";
            this._helpLabel.Size = new System.Drawing.Size(510, 32);
            this._helpLabel.TabIndex = 5;
            this._helpLabel.Text = "Click [▶ START] to ask the audience to vote";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._closeButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._helpLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 711);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PollGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._closeButton;
            this.ClientSize = new System.Drawing.Size(803, 743);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PollGameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Poll Game";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox _votesList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _startGuessButton;
        private System.Windows.Forms.Button _stopGuessButton;
        private System.Windows.Forms.Label _guessTimeLabel;
        private System.Windows.Forms.Timer _guessTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.Label _helpLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
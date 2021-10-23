
namespace GsgBot
{
    partial class NumberGuessSetupForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this._nameLabel = new System.Windows.Forms.Label();
            this._nameText = new System.Windows.Forms.TextBox();
            this._startMessageLabel = new System.Windows.Forms.Label();
            this._startMessageText = new System.Windows.Forms.TextBox();
            this._endMessageLabel = new System.Windows.Forms.Label();
            this._endMessageText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this._numberRadio = new System.Windows.Forms.RadioButton();
            this._timeRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 690);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._saveButton);
            this.flowLayoutPanel1.Controls.Add(this._cancelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(679, 626);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // _saveButton
            // 
            this._saveButton.AutoSize = true;
            this._saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._saveButton.Location = new System.Drawing.Point(3, 3);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._saveButton.Size = new System.Drawing.Size(129, 45);
            this._saveButton.TabIndex = 7;
            this._saveButton.Text = "✔️ Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.AutoSize = true;
            this._cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._cancelButton.Location = new System.Drawing.Point(138, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this._cancelButton.Size = new System.Drawing.Size(113, 45);
            this._cancelButton.TabIndex = 8;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this._nameLabel);
            this.flowLayoutPanel2.Controls.Add(this._nameText);
            this.flowLayoutPanel2.Controls.Add(this._startMessageLabel);
            this.flowLayoutPanel2.Controls.Add(this._startMessageText);
            this.flowLayoutPanel2.Controls.Add(this._endMessageLabel);
            this.flowLayoutPanel2.Controls.Add(this._endMessageText);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(920, 607);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(3, 0);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(63, 25);
            this._nameLabel.TabIndex = 1;
            this._nameLabel.Text = "Name:";
            // 
            // _nameText
            // 
            this._nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._nameText.Location = new System.Drawing.Point(3, 28);
            this._nameText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this._nameText.Name = "_nameText";
            this._nameText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._nameText.Size = new System.Drawing.Size(800, 39);
            this._nameText.TabIndex = 2;
            // 
            // _startMessageLabel
            // 
            this._startMessageLabel.AutoSize = true;
            this._startMessageLabel.Location = new System.Drawing.Point(3, 82);
            this._startMessageLabel.Name = "_startMessageLabel";
            this._startMessageLabel.Size = new System.Drawing.Size(372, 25);
            this._startMessageLabel.TabIndex = 3;
            this._startMessageLabel.Text = "Chat message at the start of guessing period:";
            // 
            // _startMessageText
            // 
            this._startMessageText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._startMessageText.Location = new System.Drawing.Point(3, 110);
            this._startMessageText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this._startMessageText.Multiline = true;
            this._startMessageText.Name = "_startMessageText";
            this._startMessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._startMessageText.Size = new System.Drawing.Size(800, 98);
            this._startMessageText.TabIndex = 4;
            // 
            // _endMessageLabel
            // 
            this._endMessageLabel.AutoSize = true;
            this._endMessageLabel.Location = new System.Drawing.Point(3, 223);
            this._endMessageLabel.Name = "_endMessageLabel";
            this._endMessageLabel.Size = new System.Drawing.Size(367, 25);
            this._endMessageLabel.TabIndex = 5;
            this._endMessageLabel.Text = "Chat message at the end of guessing period:";
            // 
            // _endMessageText
            // 
            this._endMessageText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._endMessageText.Location = new System.Drawing.Point(3, 251);
            this._endMessageText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this._endMessageText.Multiline = true;
            this._endMessageText.Name = "_endMessageText";
            this._endMessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._endMessageText.Size = new System.Drawing.Size(800, 98);
            this._endMessageText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type of guesses:";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this._numberRadio);
            this.flowLayoutPanel3.Controls.Add(this._timeRadio);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 392);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(189, 35);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // _numberRadio
            // 
            this._numberRadio.AutoSize = true;
            this._numberRadio.Checked = true;
            this._numberRadio.Location = new System.Drawing.Point(3, 3);
            this._numberRadio.Name = "_numberRadio";
            this._numberRadio.Size = new System.Drawing.Size(102, 29);
            this._numberRadio.TabIndex = 0;
            this._numberRadio.TabStop = true;
            this._numberRadio.Text = "Number";
            this._numberRadio.UseVisualStyleBackColor = true;
            // 
            // _timeRadio
            // 
            this._timeRadio.AutoSize = true;
            this._timeRadio.Location = new System.Drawing.Point(111, 3);
            this._timeRadio.Name = "_timeRadio";
            this._timeRadio.Size = new System.Drawing.Size(75, 29);
            this._timeRadio.TabIndex = 1;
            this._timeRadio.Text = "Time";
            this._timeRadio.UseVisualStyleBackColor = true;
            // 
            // NumberGuessSetupForm
            // 
            this.AcceptButton = this._saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(946, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumberGuessSetupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Number Guess Setup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label _startMessageLabel;
        private System.Windows.Forms.TextBox _startMessageText;
        private System.Windows.Forms.Label _endMessageLabel;
        private System.Windows.Forms.TextBox _endMessageText;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton _numberRadio;
        private System.Windows.Forms.RadioButton _timeRadio;
    }
}
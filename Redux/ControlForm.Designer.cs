namespace Redux
{
    partial class ControlForm
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
            this.ConsoleTap = new System.Windows.Forms.TabPage();
            this.Debugging = new System.Windows.Forms.GroupBox();
            this.DebugState = new System.Windows.Forms.Label();
            this.DebugBu = new System.Windows.Forms.Button();
            this.ConsoleLable = new System.Windows.Forms.Label();
            this.ConsoleSave = new System.Windows.Forms.Button();
            this.ClearConsoleText = new System.Windows.Forms.Button();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.TabPage();
            this.NoteLable = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.RichTextBox();
            this.LoadNote = new System.Windows.Forms.Button();
            this.ReadNotes = new System.Windows.Forms.Button();
            this.SaveNotes = new System.Windows.Forms.Button();
            this.CPanel = new System.Windows.Forms.TabPage();
            this.ClientListTextBox = new System.Windows.Forms.TextBox();
            this.OnlineCountTextbox = new System.Windows.Forms.Label();
            this.OnlineCountLabel = new System.Windows.Forms.Label();
            this.Scan = new System.Windows.Forms.Button();
            this.TapConsole = new System.Windows.Forms.TabControl();
            this.ConsoleTap.SuspendLayout();
            this.Debugging.SuspendLayout();
            this.Notes.SuspendLayout();
            this.CPanel.SuspendLayout();
            this.TapConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleTap
            // 
            this.ConsoleTap.BackColor = System.Drawing.Color.Transparent;
            this.ConsoleTap.Controls.Add(this.Debugging);
            this.ConsoleTap.Controls.Add(this.ConsoleLable);
            this.ConsoleTap.Controls.Add(this.ConsoleSave);
            this.ConsoleTap.Controls.Add(this.ClearConsoleText);
            this.ConsoleTap.Controls.Add(this.ConsoleText);
            this.ConsoleTap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConsoleTap.Location = new System.Drawing.Point(4, 29);
            this.ConsoleTap.Name = "ConsoleTap";
            this.ConsoleTap.Padding = new System.Windows.Forms.Padding(3);
            this.ConsoleTap.Size = new System.Drawing.Size(770, 372);
            this.ConsoleTap.TabIndex = 3;
            this.ConsoleTap.Text = "Console";
            // 
            // Debugging
            // 
            this.Debugging.Controls.Add(this.DebugState);
            this.Debugging.Controls.Add(this.DebugBu);
            this.Debugging.Location = new System.Drawing.Point(644, 283);
            this.Debugging.Name = "Debugging";
            this.Debugging.Size = new System.Drawing.Size(108, 81);
            this.Debugging.TabIndex = 9;
            this.Debugging.TabStop = false;
            this.Debugging.Text = "Debugging";
            // 
            // DebugState
            // 
            this.DebugState.AutoSize = true;
            this.DebugState.ForeColor = System.Drawing.Color.Red;
            this.DebugState.Location = new System.Drawing.Point(6, 29);
            this.DebugState.Name = "DebugState";
            this.DebugState.Size = new System.Drawing.Size(100, 13);
            this.DebugState.TabIndex = 10;
            this.DebugState.Text = "Debug Mode - Fase";
            // 
            // DebugBu
            // 
            this.DebugBu.AccessibleDescription = "";
            this.DebugBu.Location = new System.Drawing.Point(18, 45);
            this.DebugBu.Name = "DebugBu";
            this.DebugBu.Size = new System.Drawing.Size(75, 30);
            this.DebugBu.TabIndex = 8;
            this.DebugBu.Text = "Debug";
            this.DebugBu.UseVisualStyleBackColor = true;
            this.DebugBu.Click += new System.EventHandler(this.DebugBu_Click);
            // 
            // ConsoleLable
            // 
            this.ConsoleLable.AutoSize = true;
            this.ConsoleLable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLable.ForeColor = System.Drawing.Color.DarkRed;
            this.ConsoleLable.Location = new System.Drawing.Point(267, 7);
            this.ConsoleLable.Name = "ConsoleLable";
            this.ConsoleLable.Size = new System.Drawing.Size(86, 16);
            this.ConsoleLable.TabIndex = 7;
            this.ConsoleLable.Text = ":: Console ::";
            // 
            // ConsoleSave
            // 
            this.ConsoleSave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ConsoleSave.Location = new System.Drawing.Point(662, 62);
            this.ConsoleSave.Name = "ConsoleSave";
            this.ConsoleSave.Size = new System.Drawing.Size(75, 30);
            this.ConsoleSave.TabIndex = 2;
            this.ConsoleSave.Text = "Save";
            this.ConsoleSave.UseVisualStyleBackColor = true;
            this.ConsoleSave.Click += new System.EventHandler(this.ConsoleSave_Click);
            // 
            // ClearConsoleText
            // 
            this.ClearConsoleText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearConsoleText.Location = new System.Drawing.Point(662, 26);
            this.ClearConsoleText.Name = "ClearConsoleText";
            this.ClearConsoleText.Size = new System.Drawing.Size(75, 30);
            this.ClearConsoleText.TabIndex = 1;
            this.ClearConsoleText.Text = "Clear";
            this.ClearConsoleText.UseVisualStyleBackColor = true;
            this.ClearConsoleText.Click += new System.EventHandler(this.ClearConsoleText_Click);
            // 
            // ConsoleText
            // 
            this.ConsoleText.BackColor = System.Drawing.SystemColors.MenuText;
            this.ConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleText.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleText.ForeColor = System.Drawing.Color.Green;
            this.ConsoleText.Location = new System.Drawing.Point(3, 26);
            this.ConsoleText.Multiline = true;
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.ReadOnly = true;
            this.ConsoleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleText.Size = new System.Drawing.Size(635, 338);
            this.ConsoleText.TabIndex = 0;
            this.ConsoleText.TabStop = false;
            this.ConsoleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.Transparent;
            this.Notes.Controls.Add(this.NoteLable);
            this.Notes.Controls.Add(this.NoteBox);
            this.Notes.Controls.Add(this.LoadNote);
            this.Notes.Controls.Add(this.ReadNotes);
            this.Notes.Controls.Add(this.SaveNotes);
            this.Notes.Location = new System.Drawing.Point(4, 29);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(770, 372);
            this.Notes.TabIndex = 2;
            this.Notes.Text = "Notes";
            // 
            // NoteLable
            // 
            this.NoteLable.AutoSize = true;
            this.NoteLable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLable.ForeColor = System.Drawing.Color.DarkRed;
            this.NoteLable.Location = new System.Drawing.Point(267, 7);
            this.NoteLable.Name = "NoteLable";
            this.NoteLable.Size = new System.Drawing.Size(93, 16);
            this.NoteLable.TabIndex = 6;
            this.NoteLable.Text = ":: Note Box ::";
            // 
            // NoteBox
            // 
            this.NoteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NoteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoteBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NoteBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteBox.ForeColor = System.Drawing.Color.Firebrick;
            this.NoteBox.Location = new System.Drawing.Point(3, 26);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.NoteBox.Size = new System.Drawing.Size(635, 338);
            this.NoteBox.TabIndex = 5;
            this.NoteBox.Text = "";
            // 
            // LoadNote
            // 
            this.LoadNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadNote.Location = new System.Drawing.Point(662, 323);
            this.LoadNote.Name = "LoadNote";
            this.LoadNote.Size = new System.Drawing.Size(75, 30);
            this.LoadNote.TabIndex = 4;
            this.LoadNote.Text = "Browse..";
            this.LoadNote.UseVisualStyleBackColor = true;
            this.LoadNote.Click += new System.EventHandler(this.LoadNote_Click);
            // 
            // ReadNotes
            // 
            this.ReadNotes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReadNotes.Location = new System.Drawing.Point(662, 62);
            this.ReadNotes.Name = "ReadNotes";
            this.ReadNotes.Size = new System.Drawing.Size(75, 30);
            this.ReadNotes.TabIndex = 3;
            this.ReadNotes.Text = "Read Notes";
            this.ReadNotes.UseVisualStyleBackColor = true;
            this.ReadNotes.Click += new System.EventHandler(this.ReadNotes_Click);
            // 
            // SaveNotes
            // 
            this.SaveNotes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveNotes.Location = new System.Drawing.Point(662, 26);
            this.SaveNotes.Name = "SaveNotes";
            this.SaveNotes.Size = new System.Drawing.Size(75, 30);
            this.SaveNotes.TabIndex = 1;
            this.SaveNotes.Text = "Save Notes";
            this.SaveNotes.UseVisualStyleBackColor = true;
            this.SaveNotes.Click += new System.EventHandler(this.SaveNotes_Click);
            // 
            // CPanel
            // 
            this.CPanel.BackColor = System.Drawing.Color.Transparent;
            this.CPanel.Controls.Add(this.ClientListTextBox);
            this.CPanel.Controls.Add(this.OnlineCountTextbox);
            this.CPanel.Controls.Add(this.OnlineCountLabel);
            this.CPanel.Controls.Add(this.Scan);
            this.CPanel.Location = new System.Drawing.Point(4, 29);
            this.CPanel.Name = "CPanel";
            this.CPanel.Padding = new System.Windows.Forms.Padding(3);
            this.CPanel.Size = new System.Drawing.Size(770, 372);
            this.CPanel.TabIndex = 1;
            this.CPanel.Text = "Control Panel";
            // 
            // ClientListTextBox
            // 
            this.ClientListTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ClientListTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientListTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineCountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientListTextBox.Location = new System.Drawing.Point(586, 14);
            this.ClientListTextBox.Multiline = true;
            this.ClientListTextBox.Name = "ClientListTextBox";
            this.ClientListTextBox.ReadOnly = true;
            this.ClientListTextBox.Size = new System.Drawing.Size(151, 335);
            this.ClientListTextBox.TabIndex = 4;
            this.ClientListTextBox.Text = "Empty";
            this.ClientListTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OnlineCountTextbox
            // 
            this.OnlineCountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnlineCountTextbox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineCountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OnlineCountTextbox.Location = new System.Drawing.Point(68, 10);
            this.OnlineCountTextbox.Name = "OnlineCountTextbox";
            this.OnlineCountTextbox.Size = new System.Drawing.Size(76, 23);
            this.OnlineCountTextbox.TabIndex = 4;
            this.OnlineCountTextbox.Text = "0";
            // 
            // OnlineCountLabel
            // 

            this.OnlineCountLabel.AutoSize = true;
            this.OnlineCountLabel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineCountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OnlineCountLabel.Location = new System.Drawing.Point(6, 16);
            this.OnlineCountLabel.Name = "OnlineCountLabel";
            this.OnlineCountLabel.Size = new System.Drawing.Size(56, 14);
            this.OnlineCountLabel.TabIndex = 5;
            this.OnlineCountLabel.Text = "Online:";
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(493, 7);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(75, 30);
            this.Scan.TabIndex = 0;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            // 
            // TapConsole
            // 
            this.TapConsole.AccessibleName = "";
            this.TapConsole.Controls.Add(this.CPanel);
            this.TapConsole.Controls.Add(this.Notes);
            this.TapConsole.Controls.Add(this.ConsoleTap);
            this.TapConsole.ItemSize = new System.Drawing.Size(75, 25);
            this.TapConsole.Location = new System.Drawing.Point(8, 1);
            this.TapConsole.Name = "TapConsole";
            this.TapConsole.SelectedIndex = 0;
            this.TapConsole.Size = new System.Drawing.Size(778, 405);
            this.TapConsole.TabIndex = 5;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(794, 410);
            this.Controls.Add(this.TapConsole);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ControlForm";
            this.Text = "[Redux]";
            this.ConsoleTap.ResumeLayout(false);
            this.ConsoleTap.PerformLayout();
            this.Debugging.ResumeLayout(false);
            this.Debugging.PerformLayout();
            this.Notes.ResumeLayout(false);
            this.Notes.PerformLayout();
            this.CPanel.ResumeLayout(false);
            this.CPanel.PerformLayout();
            this.TapConsole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ConsoleTap;
        private System.Windows.Forms.GroupBox Debugging;
        private System.Windows.Forms.Label DebugState;
        private System.Windows.Forms.Button DebugBu;
        private System.Windows.Forms.Label ConsoleLable;
        private System.Windows.Forms.Button ConsoleSave;
        private System.Windows.Forms.Button ClearConsoleText;
        private System.Windows.Forms.TextBox ConsoleText;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.Label NoteLable;
        private System.Windows.Forms.RichTextBox NoteBox;
        private System.Windows.Forms.Button LoadNote;
        private System.Windows.Forms.Button ReadNotes;
        private System.Windows.Forms.Button SaveNotes;
        private System.Windows.Forms.TabPage CPanel;
        private System.Windows.Forms.Label OnlineCountTextbox;
        private System.Windows.Forms.Label OnlineCountLabel;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.TabControl TapConsole;
        private System.Windows.Forms.TextBox ClientListTextBox;

    }
}


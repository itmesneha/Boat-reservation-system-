namespace Library_Management_System
{
    partial class AppBody
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
            this.Log_in_Timer = new System.Windows.Forms.Timer(this.components);
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.settingstab_button = new System.Windows.Forms.Button();
            this.BoatsTab_Button = new System.Windows.Forms.Button();
            this.borrowerstab_button = new System.Windows.Forms.Button();
            this.AboutTab_Button = new System.Windows.Forms.Button();
            this.TransactionTab_Button = new System.Windows.Forms.Button();
            this.SlidingPanel_ToggleButton = new System.Windows.Forms.Button();
            this.SlidingPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.TitleBarPanel.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_Timer
            // 
            this.Log_in_Timer.Interval = 20;
            this.Log_in_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.LogOffButton);
            this.TitleBarPanel.Controls.Add(this.CloseButton);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(1328, 41);
            this.TitleBarPanel.TabIndex = 0;
            this.TitleBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBarPanel_Paint);
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeButton.Location = new System.Drawing.Point(1235, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(37, 41);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "__";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // LogOffButton
            // 
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffButton.Location = new System.Drawing.Point(1179, 0);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(50, 41);
            this.LogOffButton.TabIndex = 2;
            this.LogOffButton.Text = "( | )";
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1278, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 41);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SlidingPanel.Controls.Add(this.settingstab_button);
            this.SlidingPanel.Controls.Add(this.BoatsTab_Button);
            this.SlidingPanel.Controls.Add(this.borrowerstab_button);
            this.SlidingPanel.Controls.Add(this.AboutTab_Button);
            this.SlidingPanel.Controls.Add(this.TransactionTab_Button);
            this.SlidingPanel.Controls.Add(this.SlidingPanel_ToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 41);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(300, 377);
            this.SlidingPanel.TabIndex = 1;
            // 
            // settingstab_button
            // 
            this.settingstab_button.BackColor = System.Drawing.Color.Gray;
            this.settingstab_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingstab_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingstab_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingstab_button.Location = new System.Drawing.Point(0, 167);
            this.settingstab_button.Name = "settingstab_button";
            this.settingstab_button.Size = new System.Drawing.Size(266, 60);
            this.settingstab_button.TabIndex = 7;
            this.settingstab_button.Text = "settings";
            this.settingstab_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingstab_button.UseVisualStyleBackColor = false;
            this.settingstab_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // BoatsTab_Button
            // 
            this.BoatsTab_Button.BackColor = System.Drawing.Color.Gray;
            this.BoatsTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoatsTab_Button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoatsTab_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BoatsTab_Button.Location = new System.Drawing.Point(0, 55);
            this.BoatsTab_Button.Name = "BoatsTab_Button";
            this.BoatsTab_Button.Size = new System.Drawing.Size(266, 60);
            this.BoatsTab_Button.TabIndex = 5;
            this.BoatsTab_Button.Text = "boats";
            this.BoatsTab_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BoatsTab_Button.UseVisualStyleBackColor = false;
            this.BoatsTab_Button.Click += new System.EventHandler(this.BoatsTab_Button_Click);
            // 
            // borrowerstab_button
            // 
            this.borrowerstab_button.BackColor = System.Drawing.Color.Gray;
            this.borrowerstab_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowerstab_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerstab_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.borrowerstab_button.Location = new System.Drawing.Point(0, 112);
            this.borrowerstab_button.Name = "borrowerstab_button";
            this.borrowerstab_button.Size = new System.Drawing.Size(266, 60);
            this.borrowerstab_button.TabIndex = 6;
            this.borrowerstab_button.Text = "borrowers";
            this.borrowerstab_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowerstab_button.UseVisualStyleBackColor = false;
            this.borrowerstab_button.Click += new System.EventHandler(this.borrowers_button_Click);
            // 
            // AboutTab_Button
            // 
            this.AboutTab_Button.BackColor = System.Drawing.Color.Gray;
            this.AboutTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTab_Button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTab_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AboutTab_Button.Location = new System.Drawing.Point(0, 285);
            this.AboutTab_Button.Name = "AboutTab_Button";
            this.AboutTab_Button.Size = new System.Drawing.Size(266, 69);
            this.AboutTab_Button.TabIndex = 2;
            this.AboutTab_Button.Text = "about";
            this.AboutTab_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutTab_Button.UseVisualStyleBackColor = false;
            this.AboutTab_Button.Click += new System.EventHandler(this.AboutTab_Button_Click);
            // 
            // TransactionTab_Button
            // 
            this.TransactionTab_Button.BackColor = System.Drawing.Color.Gray;
            this.TransactionTab_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionTab_Button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionTab_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TransactionTab_Button.Location = new System.Drawing.Point(0, 221);
            this.TransactionTab_Button.Name = "TransactionTab_Button";
            this.TransactionTab_Button.Size = new System.Drawing.Size(266, 67);
            this.TransactionTab_Button.TabIndex = 3;
            this.TransactionTab_Button.Text = "transactions";
            this.TransactionTab_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionTab_Button.UseVisualStyleBackColor = false;
            this.TransactionTab_Button.Click += new System.EventHandler(this.TransactionTab_Button_Click);
            // 
            // SlidingPanel_ToggleButton
            // 
            this.SlidingPanel_ToggleButton.BackColor = System.Drawing.Color.Gray;
            this.SlidingPanel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPanel_ToggleButton.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlidingPanel_ToggleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SlidingPanel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel_ToggleButton.Name = "SlidingPanel_ToggleButton";
            this.SlidingPanel_ToggleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SlidingPanel_ToggleButton.Size = new System.Drawing.Size(266, 60);
            this.SlidingPanel_ToggleButton.TabIndex = 0;
            this.SlidingPanel_ToggleButton.Text = "back";
            this.SlidingPanel_ToggleButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SlidingPanel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPanel_ToggleButton.Click += new System.EventHandler(this.SlidingPanel_ToggleButton_Click);
            // 
            // SlidingPanel_Timer
            // 
            this.SlidingPanel_Timer.Interval = 10;
            this.SlidingPanel_Timer.Tick += new System.EventHandler(this.SlidingPanel_Timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpanel.Location = new System.Drawing.Point(261, 41);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1067, 377);
            this.contentpanel.TabIndex = 2;
            this.contentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentpanel_Paint);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 418);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_Timer;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanel_ToggleButton;
        private System.Windows.Forms.Timer SlidingPanel_Timer;
        private System.Windows.Forms.Button BoatsTab_Button;
        private System.Windows.Forms.Button TransactionTab_Button;
        private System.Windows.Forms.Button AboutTab_Button;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Button settingstab_button;
        private System.Windows.Forms.Button borrowerstab_button;
    }
}
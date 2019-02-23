namespace Library_Management_System
{
    partial class Settings_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.success_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Login Credentials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Product Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(262, 105);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(206, 41);
            this.username_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Product Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(262, 208);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(206, 41);
            this.password_textbox.TabIndex = 4;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_button.Font = new System.Drawing.Font("Product Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(567, 157);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(168, 47);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Change";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // success_label
            // 
            this.success_label.AutoSize = true;
            this.success_label.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success_label.Location = new System.Drawing.Point(571, 224);
            this.success_label.Name = "success_label";
            this.success_label.Size = new System.Drawing.Size(0, 39);
            this.success_label.TabIndex = 6;
            // 
            // Settings_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.success_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings_UserControl";
            this.Size = new System.Drawing.Size(1029, 377);
            this.Load += new System.EventHandler(this.Settings_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label success_label;
    }
}

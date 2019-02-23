namespace Library_Management_System
{
    partial class Boats_UserControl
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
            this.BoatCode = new System.Windows.Forms.Label();
            this.Search_textbox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.AccNo_label = new System.Windows.Forms.Label();
            this.AccNo_textbox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Owner_label = new System.Windows.Forms.Label();
            this.Owner_textbox = new System.Windows.Forms.TextBox();
            this.Brand_label = new System.Windows.Forms.Label();
            this.Brand_textbox = new System.Windows.Forms.TextBox();
            this.BoatCode_label = new System.Windows.Forms.Label();
            this.BoatCode_textbox = new System.Windows.Forms.TextBox();
            this.Department_Combobox = new System.Windows.Forms.ComboBox();
            this.Department_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoatCode
            // 
            this.BoatCode.AutoSize = true;
            this.BoatCode.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoatCode.Location = new System.Drawing.Point(44, 21);
            this.BoatCode.Name = "BoatCode";
            this.BoatCode.Size = new System.Drawing.Size(212, 29);
            this.BoatCode.TabIndex = 0;
            this.BoatCode.Text = "Accession Number";
            this.BoatCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // Search_textbox
            // 
            this.Search_textbox.BackColor = System.Drawing.Color.White;
            this.Search_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_textbox.Location = new System.Drawing.Point(256, 19);
            this.Search_textbox.Name = "Search_textbox";
            this.Search_textbox.Size = new System.Drawing.Size(391, 37);
            this.Search_textbox.TabIndex = 1;
            this.Search_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(700, 15);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(124, 41);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(973, 137);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.Location = new System.Drawing.Point(26, 241);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(111, 35);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.Location = new System.Drawing.Point(280, 241);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(111, 35);
            this.Update_button.TabIndex = 5;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(550, 241);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(111, 35);
            this.Delete_button.TabIndex = 6;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.Location = new System.Drawing.Point(773, 241);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(111, 35);
            this.Clear_button.TabIndex = 7;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // AccNo_label
            // 
            this.AccNo_label.AutoSize = true;
            this.AccNo_label.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNo_label.Location = new System.Drawing.Point(22, 298);
            this.AccNo_label.Name = "AccNo_label";
            this.AccNo_label.Size = new System.Drawing.Size(90, 29);
            this.AccNo_label.TabIndex = 8;
            this.AccNo_label.Text = "Acc No";
            // 
            // AccNo_textbox
            // 
            this.AccNo_textbox.BackColor = System.Drawing.Color.White;
            this.AccNo_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccNo_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNo_textbox.Location = new System.Drawing.Point(26, 337);
            this.AccNo_textbox.Name = "AccNo_textbox";
            this.AccNo_textbox.Size = new System.Drawing.Size(130, 37);
            this.AccNo_textbox.TabIndex = 9;
            this.AccNo_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(181, 298);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(75, 29);
            this.Name_label.TabIndex = 10;
            this.Name_label.Text = "Name";
            // 
            // Name_textbox
            // 
            this.Name_textbox.BackColor = System.Drawing.Color.White;
            this.Name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textbox.Location = new System.Drawing.Point(186, 337);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(130, 37);
            this.Name_textbox.TabIndex = 11;
            this.Name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Owner_label
            // 
            this.Owner_label.AutoSize = true;
            this.Owner_label.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owner_label.Location = new System.Drawing.Point(342, 298);
            this.Owner_label.Name = "Owner_label";
            this.Owner_label.Size = new System.Drawing.Size(85, 29);
            this.Owner_label.TabIndex = 12;
            this.Owner_label.Text = "Owner";
            // 
            // Owner_textbox
            // 
            this.Owner_textbox.BackColor = System.Drawing.Color.White;
            this.Owner_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Owner_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owner_textbox.Location = new System.Drawing.Point(347, 337);
            this.Owner_textbox.Name = "Owner_textbox";
            this.Owner_textbox.Size = new System.Drawing.Size(130, 37);
            this.Owner_textbox.TabIndex = 13;
            this.Owner_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Brand_label
            // 
            this.Brand_label.AutoSize = true;
            this.Brand_label.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_label.Location = new System.Drawing.Point(512, 298);
            this.Brand_label.Name = "Brand_label";
            this.Brand_label.Size = new System.Drawing.Size(75, 29);
            this.Brand_label.TabIndex = 14;
            this.Brand_label.Text = "Brand";
            this.Brand_label.Click += new System.EventHandler(this.label5_Click);
            // 
            // Brand_textbox
            // 
            this.Brand_textbox.BackColor = System.Drawing.Color.White;
            this.Brand_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Brand_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_textbox.Location = new System.Drawing.Point(517, 337);
            this.Brand_textbox.Name = "Brand_textbox";
            this.Brand_textbox.Size = new System.Drawing.Size(130, 37);
            this.Brand_textbox.TabIndex = 15;
            this.Brand_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BoatCode_label
            // 
            this.BoatCode_label.AutoSize = true;
            this.BoatCode_label.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoatCode_label.Location = new System.Drawing.Point(689, 298);
            this.BoatCode_label.Name = "BoatCode_label";
            this.BoatCode_label.Size = new System.Drawing.Size(117, 29);
            this.BoatCode_label.TabIndex = 16;
            this.BoatCode_label.Text = "BoatCode";
            // 
            // BoatCode_textbox
            // 
            this.BoatCode_textbox.BackColor = System.Drawing.Color.White;
            this.BoatCode_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoatCode_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoatCode_textbox.Location = new System.Drawing.Point(694, 337);
            this.BoatCode_textbox.Name = "BoatCode_textbox";
            this.BoatCode_textbox.Size = new System.Drawing.Size(130, 37);
            this.BoatCode_textbox.TabIndex = 17;
            this.BoatCode_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Department_Combobox
            // 
            this.Department_Combobox.FormattingEnabled = true;
            this.Department_Combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Department_Combobox.Location = new System.Drawing.Point(865, 343);
            this.Department_Combobox.Name = "Department_Combobox";
            this.Department_Combobox.Size = new System.Drawing.Size(121, 28);
            this.Department_Combobox.TabIndex = 18;
            // 
            // Department_label
            // 
            this.Department_label.AutoSize = true;
            this.Department_label.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_label.Location = new System.Drawing.Point(859, 298);
            this.Department_label.Name = "Department_label";
            this.Department_label.Size = new System.Drawing.Size(140, 29);
            this.Department_label.TabIndex = 19;
            this.Department_label.Text = "Department";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(941, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Boats_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Department_label);
            this.Controls.Add(this.Department_Combobox);
            this.Controls.Add(this.BoatCode_textbox);
            this.Controls.Add(this.BoatCode_label);
            this.Controls.Add(this.Brand_textbox);
            this.Controls.Add(this.Brand_label);
            this.Controls.Add(this.Owner_textbox);
            this.Controls.Add(this.Owner_label);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.AccNo_textbox);
            this.Controls.Add(this.AccNo_label);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_textbox);
            this.Controls.Add(this.BoatCode);
            this.Name = "Boats_UserControl";
            this.Size = new System.Drawing.Size(1067, 418);
            this.Load += new System.EventHandler(this.Boats_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BoatCode;
        private System.Windows.Forms.TextBox Search_textbox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Label AccNo_label;
        private System.Windows.Forms.TextBox AccNo_textbox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.Label Owner_label;
        private System.Windows.Forms.TextBox Owner_textbox;
        private System.Windows.Forms.Label Brand_label;
        private System.Windows.Forms.TextBox Brand_textbox;
        private System.Windows.Forms.Label BoatCode_label;
        private System.Windows.Forms.TextBox BoatCode_textbox;
        private System.Windows.Forms.ComboBox Department_Combobox;
        private System.Windows.Forms.Label Department_label;
        private System.Windows.Forms.Button button1;
    }
}

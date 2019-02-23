namespace Library_Management_System
{
    partial class Borrowers_UserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.addborrower_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeborrower_button = new System.Windows.Forms.Button();
            this.showdata_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(978, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_textbox.Location = new System.Drawing.Point(63, 250);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(141, 37);
            this.id_textbox.TabIndex = 1;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_textbox.Location = new System.Drawing.Point(643, 250);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(141, 37);
            this.phone_textbox.TabIndex = 2;
            // 
            // address_textbox
            // 
            this.address_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_textbox.Location = new System.Drawing.Point(452, 250);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(141, 37);
            this.address_textbox.TabIndex = 3;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(250, 250);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(141, 37);
            this.name_textbox.TabIndex = 4;
            // 
            // addborrower_button
            // 
            this.addborrower_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addborrower_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addborrower_button.Location = new System.Drawing.Point(811, 250);
            this.addborrower_button.Name = "addborrower_button";
            this.addborrower_button.Size = new System.Drawing.Size(210, 37);
            this.addborrower_button.TabIndex = 5;
            this.addborrower_button.Text = "Add Borrower";
            this.addborrower_button.UseVisualStyleBackColor = false;
            this.addborrower_button.Click += new System.EventHandler(this.addborrower_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone ";
            // 
            // removeborrower_button
            // 
            this.removeborrower_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.removeborrower_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeborrower_button.Location = new System.Drawing.Point(811, 305);
            this.removeborrower_button.Name = "removeborrower_button";
            this.removeborrower_button.Size = new System.Drawing.Size(210, 37);
            this.removeborrower_button.TabIndex = 10;
            this.removeborrower_button.Text = "Remove Borrower";
            this.removeborrower_button.UseVisualStyleBackColor = false;
            this.removeborrower_button.Click += new System.EventHandler(this.removeborrower_button_Click);
            // 
            // showdata_button
            // 
            this.showdata_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.showdata_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showdata_button.Location = new System.Drawing.Point(542, 305);
            this.showdata_button.Name = "showdata_button";
            this.showdata_button.Size = new System.Drawing.Size(210, 37);
            this.showdata_button.TabIndex = 11;
            this.showdata_button.Text = "Show Data";
            this.showdata_button.UseVisualStyleBackColor = false;
            this.showdata_button.Click += new System.EventHandler(this.showdata_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.clear_button.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(302, 305);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(210, 37);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "Clear All";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Borrowers_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.showdata_button);
            this.Controls.Add(this.removeborrower_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addborrower_button);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Borrowers_UserControl";
            this.Size = new System.Drawing.Size(1067, 377);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button addborrower_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeborrower_button;
        private System.Windows.Forms.Button showdata_button;
        private System.Windows.Forms.Button clear_button;
    }
}

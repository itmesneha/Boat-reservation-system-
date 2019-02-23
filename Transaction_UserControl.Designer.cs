namespace Library_Management_System
{
    partial class Transaction_UserControl
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
            this.borrowedby_label = new System.Windows.Forms.Label();
            this.borrowedby2_label = new System.Windows.Forms.Label();
            this.borrowedby1_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.returnnboat_button = new System.Windows.Forms.Button();
            this.issueboat_button = new System.Windows.Forms.Button();
            this.clearall_button = new System.Windows.Forms.Button();
            this.searchboats_button = new System.Windows.Forms.Button();
            this.accno_textbox = new System.Windows.Forms.TextBox();
            this.accno_label = new System.Windows.Forms.Label();
            this.boat2_label = new System.Windows.Forms.Label();
            this.boat1_label = new System.Windows.Forms.Label();
            this.Searchborrowers_button = new System.Windows.Forms.Button();
            this.borrowerid_textbox = new System.Windows.Forms.TextBox();
            this.borrowerid_label = new System.Windows.Forms.Label();
            this.transactionlog_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowedby_label
            // 
            this.borrowedby_label.AutoSize = true;
            this.borrowedby_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.borrowedby_label.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedby_label.Location = new System.Drawing.Point(889, 101);
            this.borrowedby_label.Name = "borrowedby_label";
            this.borrowedby_label.Size = new System.Drawing.Size(101, 27);
            this.borrowedby_label.TabIndex = 29;
            this.borrowedby_label.Text = "borrower";
            // 
            // borrowedby2_label
            // 
            this.borrowedby2_label.AutoSize = true;
            this.borrowedby2_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.borrowedby2_label.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedby2_label.Location = new System.Drawing.Point(889, 61);
            this.borrowedby2_label.Name = "borrowedby2_label";
            this.borrowedby2_label.Size = new System.Drawing.Size(67, 27);
            this.borrowedby2_label.TabIndex = 28;
            this.borrowedby2_label.Text = "boat2";
            // 
            // borrowedby1_label
            // 
            this.borrowedby1_label.AutoSize = true;
            this.borrowedby1_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.borrowedby1_label.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedby1_label.Location = new System.Drawing.Point(889, 15);
            this.borrowedby1_label.Name = "borrowedby1_label";
            this.borrowedby1_label.Size = new System.Drawing.Size(64, 27);
            this.borrowedby1_label.TabIndex = 27;
            this.borrowedby1_label.Text = "boat1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(734, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Borrowed By";
            // 
            // returnnboat_button
            // 
            this.returnnboat_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.returnnboat_button.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnnboat_button.Location = new System.Drawing.Point(298, 176);
            this.returnnboat_button.Name = "returnnboat_button";
            this.returnnboat_button.Size = new System.Drawing.Size(225, 43);
            this.returnnboat_button.TabIndex = 25;
            this.returnnboat_button.Text = "Return Boat";
            this.returnnboat_button.UseVisualStyleBackColor = false;
            this.returnnboat_button.Click += new System.EventHandler(this.retrunboat_button_Click);
            // 
            // issueboat_button
            // 
            this.issueboat_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.issueboat_button.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueboat_button.Location = new System.Drawing.Point(23, 176);
            this.issueboat_button.Name = "issueboat_button";
            this.issueboat_button.Size = new System.Drawing.Size(225, 43);
            this.issueboat_button.TabIndex = 24;
            this.issueboat_button.Text = "Issue Boat";
            this.issueboat_button.UseVisualStyleBackColor = false;
            this.issueboat_button.Click += new System.EventHandler(this.issueboat_button_Click);
            // 
            // clearall_button
            // 
            this.clearall_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearall_button.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearall_button.Location = new System.Drawing.Point(820, 176);
            this.clearall_button.Name = "clearall_button";
            this.clearall_button.Size = new System.Drawing.Size(156, 43);
            this.clearall_button.TabIndex = 23;
            this.clearall_button.Text = "Clear All";
            this.clearall_button.UseVisualStyleBackColor = false;
            this.clearall_button.Click += new System.EventHandler(this.clearall_button_Click);
            // 
            // searchboats_button
            // 
            this.searchboats_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchboats_button.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchboats_button.Location = new System.Drawing.Point(551, 89);
            this.searchboats_button.Name = "searchboats_button";
            this.searchboats_button.Size = new System.Drawing.Size(156, 43);
            this.searchboats_button.TabIndex = 22;
            this.searchboats_button.Text = "Search Boats";
            this.searchboats_button.UseVisualStyleBackColor = false;
            this.searchboats_button.Click += new System.EventHandler(this.searchboats_button_Click);
            // 
            // accno_textbox
            // 
            this.accno_textbox.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accno_textbox.Location = new System.Drawing.Point(203, 94);
            this.accno_textbox.Name = "accno_textbox";
            this.accno_textbox.Size = new System.Drawing.Size(320, 34);
            this.accno_textbox.TabIndex = 21;
            // 
            // accno_label
            // 
            this.accno_label.AutoSize = true;
            this.accno_label.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accno_label.Location = new System.Drawing.Point(3, 94);
            this.accno_label.Name = "accno_label";
            this.accno_label.Size = new System.Drawing.Size(194, 27);
            this.accno_label.TabIndex = 20;
            this.accno_label.Text = "Accession Number";
            // 
            // boat2_label
            // 
            this.boat2_label.AutoSize = true;
            this.boat2_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.boat2_label.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boat2_label.Location = new System.Drawing.Point(787, 61);
            this.boat2_label.Name = "boat2_label";
            this.boat2_label.Size = new System.Drawing.Size(72, 27);
            this.boat2_label.TabIndex = 19;
            this.boat2_label.Text = "Boat 2";
            // 
            // boat1_label
            // 
            this.boat1_label.AutoSize = true;
            this.boat1_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.boat1_label.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boat1_label.Location = new System.Drawing.Point(782, 15);
            this.boat1_label.Name = "boat1_label";
            this.boat1_label.Size = new System.Drawing.Size(69, 27);
            this.boat1_label.TabIndex = 18;
            this.boat1_label.Text = "Boat 1";
            // 
            // Searchborrowers_button
            // 
            this.Searchborrowers_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Searchborrowers_button.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchborrowers_button.Location = new System.Drawing.Point(551, 7);
            this.Searchborrowers_button.Name = "Searchborrowers_button";
            this.Searchborrowers_button.Size = new System.Drawing.Size(225, 43);
            this.Searchborrowers_button.TabIndex = 17;
            this.Searchborrowers_button.Text = "Search Borrowers";
            this.Searchborrowers_button.UseVisualStyleBackColor = false;
            this.Searchborrowers_button.Click += new System.EventHandler(this.Searchborrowers_button_Click);
            // 
            // borrowerid_textbox
            // 
            this.borrowerid_textbox.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerid_textbox.Location = new System.Drawing.Point(203, 12);
            this.borrowerid_textbox.Name = "borrowerid_textbox";
            this.borrowerid_textbox.Size = new System.Drawing.Size(320, 34);
            this.borrowerid_textbox.TabIndex = 16;
            // 
            // borrowerid_label
            // 
            this.borrowerid_label.AutoSize = true;
            this.borrowerid_label.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerid_label.Location = new System.Drawing.Point(18, 12);
            this.borrowerid_label.Name = "borrowerid_label";
            this.borrowerid_label.Size = new System.Drawing.Size(138, 27);
            this.borrowerid_label.TabIndex = 15;
            this.borrowerid_label.Text = "Borrower\'s Id";
            // 
            // transactionlog_button
            // 
            this.transactionlog_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transactionlog_button.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionlog_button.Location = new System.Drawing.Point(551, 176);
            this.transactionlog_button.Name = "transactionlog_button";
            this.transactionlog_button.Size = new System.Drawing.Size(225, 43);
            this.transactionlog_button.TabIndex = 30;
            this.transactionlog_button.Text = "Transaction Log";
            this.transactionlog_button.UseVisualStyleBackColor = false;
            this.transactionlog_button.Click += new System.EventHandler(this.transactionlog_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(953, 150);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Transaction_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.transactionlog_button);
            this.Controls.Add(this.borrowedby_label);
            this.Controls.Add(this.borrowedby2_label);
            this.Controls.Add(this.borrowedby1_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnnboat_button);
            this.Controls.Add(this.issueboat_button);
            this.Controls.Add(this.clearall_button);
            this.Controls.Add(this.searchboats_button);
            this.Controls.Add(this.accno_textbox);
            this.Controls.Add(this.accno_label);
            this.Controls.Add(this.boat2_label);
            this.Controls.Add(this.boat1_label);
            this.Controls.Add(this.Searchborrowers_button);
            this.Controls.Add(this.borrowerid_textbox);
            this.Controls.Add(this.borrowerid_label);
            this.Name = "Transaction_UserControl";
            this.Size = new System.Drawing.Size(1029, 377);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label borrowedby_label;
        private System.Windows.Forms.Label borrowedby2_label;
        private System.Windows.Forms.Label borrowedby1_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button returnnboat_button;
        private System.Windows.Forms.Button issueboat_button;
        private System.Windows.Forms.Button clearall_button;
        private System.Windows.Forms.Button searchboats_button;
        private System.Windows.Forms.TextBox accno_textbox;
        private System.Windows.Forms.Label accno_label;
        private System.Windows.Forms.Label boat2_label;
        private System.Windows.Forms.Label boat1_label;
        private System.Windows.Forms.Button Searchborrowers_button;
        private System.Windows.Forms.TextBox borrowerid_textbox;
        private System.Windows.Forms.Label borrowerid_label;
        private System.Windows.Forms.Button transactionlog_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

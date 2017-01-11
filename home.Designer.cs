namespace software_catalogue
{
    partial class home
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
            this.button1 = new System.Windows.Forms.Button();
            this.welcomemsg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uploader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcomemsg
            // 
            this.welcomemsg.AutoSize = true;
            this.welcomemsg.Location = new System.Drawing.Point(12, 17);
            this.welcomemsg.Name = "welcomemsg";
            this.welcomemsg.Size = new System.Drawing.Size(55, 13);
            this.welcomemsg.TabIndex = 1;
            this.welcomemsg.Text = "Welcome ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentName,
            this.Uploader,
            this.DateModified,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(53, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ComponentName
            // 
            this.ComponentName.HeaderText = "ComponentName";
            this.ComponentName.Name = "ComponentName";
            this.ComponentName.ReadOnly = true;
            this.ComponentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ComponentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Uploader
            // 
            this.Uploader.HeaderText = "Uploader";
            this.Uploader.Name = "Uploader";
            this.Uploader.ReadOnly = true;
            // 
            // DateModified
            // 
            this.DateModified.HeaderText = "DateModified";
            this.DateModified.Name = "DateModified";
            this.DateModified.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(226, 269);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 5;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 355);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.welcomemsg);
            this.Controls.Add(this.button1);
            this.Name = "home";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welcomemsg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uploader;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button Upload;
    }
}
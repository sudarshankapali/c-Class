namespace calculator
{
    partial class query
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
            this.idbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.contactbox = new System.Windows.Forms.TextBox();
            this.collegebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(149, 30);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(99, 23);
            this.idbox.TabIndex = 1;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(254, 30);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(186, 23);
            this.namebox.TabIndex = 3;
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(446, 30);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(97, 23);
            this.addressbox.TabIndex = 5;
            // 
            // contactbox
            // 
            this.contactbox.Location = new System.Drawing.Point(549, 30);
            this.contactbox.Name = "contactbox";
            this.contactbox.Size = new System.Drawing.Size(95, 23);
            this.contactbox.TabIndex = 7;
            this.contactbox.TextChanged += new System.EventHandler(this.contactbox_TextChanged);
            // 
            // collegebox
            // 
            this.collegebox.Location = new System.Drawing.Point(652, 30);
            this.collegebox.Name = "collegebox";
            this.collegebox.Size = new System.Drawing.Size(100, 23);
            this.collegebox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Set data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.contact,
            this.college});
            this.dataGridView1.Location = new System.Drawing.Point(118, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(634, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.HeaderText = "address";
            this.address.Name = "address";
            // 
            // contact
            // 
            this.contact.HeaderText = "contact";
            this.contact.Name = "contact";
            // 
            // college
            // 
            this.college.HeaderText = "college";
            this.college.Name = "college";
            // 
            // query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.collegebox);
            this.Controls.Add(this.contactbox);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.idbox);
            this.Name = "query";
            this.Text = "query";
            this.Load += new System.EventHandler(this.query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox idbox;
        private TextBox namebox;
        private TextBox addressbox;
        private TextBox contactbox;
        private TextBox collegebox;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn college;
    }
}
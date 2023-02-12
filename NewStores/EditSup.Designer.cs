namespace NewStores
{
    partial class EditSup
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Edit = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.checkBox1.Location = new System.Drawing.Point(122, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 23);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Deleted?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(122, 174);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(187, 35);
            this.Edit.TabIndex = 32;
            this.Edit.Text = "Update";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.text.ForeColor = System.Drawing.Color.Maroon;
            this.text.Location = new System.Drawing.Point(251, 21);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(102, 19);
            this.text.TabIndex = 25;
            this.text.Text = "Nothing Found";
            this.text.Visible = false;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(122, 20);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(123, 20);
            this.Search.TabIndex = 24;
            this.Search.Visible = false;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label4.Location = new System.Drawing.Point(35, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Phone #";
            // 
            // Phone
            // 
            this.Phone.Enabled = false;
            this.Phone.Location = new System.Drawing.Point(122, 109);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(284, 20);
            this.Phone.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Supplier E-Mail";
            // 
            // Email
            // 
            this.Email.Enabled = false;
            this.Email.Location = new System.Drawing.Point(122, 81);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(284, 20);
            this.Email.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Supplier Address";
            // 
            // Address
            // 
            this.Address.Enabled = false;
            this.Address.Location = new System.Drawing.Point(122, 52);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(284, 20);
            this.Address.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Supplier Name";
            // 
            // SupName
            // 
            this.SupName.Enabled = false;
            this.SupName.Location = new System.Drawing.Point(122, 22);
            this.SupName.Name = "SupName";
            this.SupName.Size = new System.Drawing.Size(284, 20);
            this.SupName.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label5.Location = new System.Drawing.Point(35, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Search";
            this.label5.Visible = false;
            // 
            // EditSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 218);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupName);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Supplier";
            this.Load += new System.EventHandler(this.EditSup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupName;
        private System.Windows.Forms.Label label5;
    }
}
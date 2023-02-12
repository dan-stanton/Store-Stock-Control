namespace NewStores
{
    partial class EditGroup
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
            this.label5 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label5.Location = new System.Drawing.Point(31, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Search";
            this.label5.Visible = false;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.text.ForeColor = System.Drawing.Color.Maroon;
            this.text.Location = new System.Drawing.Point(245, 25);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(102, 19);
            this.text.TabIndex = 44;
            this.text.Text = "Nothing Found";
            this.text.Visible = false;
            this.text.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(116, 26);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(123, 20);
            this.Search.TabIndex = 43;
            this.Search.Visible = false;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Supplier Name";
            // 
            // SupName
            // 
            this.SupName.Enabled = false;
            this.SupName.Location = new System.Drawing.Point(116, 16);
            this.SupName.Name = "SupName";
            this.SupName.Size = new System.Drawing.Size(255, 20);
            this.SupName.TabIndex = 46;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.checkBox1.Location = new System.Drawing.Point(116, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 23);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "Deleted?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(116, 71);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(187, 35);
            this.Edit.TabIndex = 48;
            this.Edit.Text = "Update";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // EditGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 118);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Group";
            this.Load += new System.EventHandler(this.EditGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Edit;
    }
}
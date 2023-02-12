namespace NewStores
{
    partial class DelGroup
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
            this.text = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.text.ForeColor = System.Drawing.Color.Maroon;
            this.text.Location = new System.Drawing.Point(55, 66);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(102, 19);
            this.text.TabIndex = 16;
            this.text.Text = "Nothing Found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.Location = new System.Drawing.Point(50, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Group Name / ID";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(46, 39);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(123, 20);
            this.Delete.TabIndex = 14;
            this.Delete.TextChanged += new System.EventHandler(this.Delete_TextChanged);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 125);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(187, 35);
            this.Create.TabIndex = 13;
            this.Create.Text = "Delete";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DelGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 172);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelGroup";
            this.Text = "Delete Group";
            this.Load += new System.EventHandler(this.DelGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Delete;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
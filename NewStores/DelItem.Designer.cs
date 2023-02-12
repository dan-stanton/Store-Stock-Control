namespace NewStores
{
    partial class DelItem
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
            this.Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(35, 125);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(187, 35);
            this.Create.TabIndex = 9;
            this.Create.Text = "Delete";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.Location = new System.Drawing.Point(64, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item ID / Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(68, 31);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(123, 20);
            this.Delete.TabIndex = 10;
            this.Delete.TextChanged += new System.EventHandler(this.Description_TextChanged);
            this.Delete.Validating += new System.ComponentModel.CancelEventHandler(this.Delete_Validating);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.text.ForeColor = System.Drawing.Color.Maroon;
            this.text.Location = new System.Drawing.Point(76, 67);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(102, 19);
            this.text.TabIndex = 12;
            this.text.Text = "Nothing Found";
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 167);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelItem";
            this.Text = "Delete Item";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Delete;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
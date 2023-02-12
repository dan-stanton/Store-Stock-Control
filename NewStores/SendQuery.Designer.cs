namespace NewStores
{
    partial class SendQuery
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
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.QueryText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(48, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(350, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Please dont use unless you know what you\'re doing\r\n";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.button6.Location = new System.Drawing.Point(133, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 44);
            this.button6.TabIndex = 28;
            this.button6.Text = "Send Query";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // QueryText
            // 
            this.QueryText.Location = new System.Drawing.Point(12, 32);
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(412, 20);
            this.QueryText.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Query";
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.Results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.Results.Location = new System.Drawing.Point(12, 88);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(56, 15);
            this.Results.TabIndex = 54;
            this.Results.Text = "Results";
            // 
            // SendQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 332);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendQuery";
            this.Text = "SQL Query";
            this.Load += new System.EventHandler(this.SendQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox QueryText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Results;
    }
}
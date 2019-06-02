namespace CSharpTask.Models
{
    partial class InfoForm
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
            this.InfoText = new System.Windows.Forms.Button();
            this.AddressText = new System.Windows.Forms.Label();
            this.PhoneText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoText.Enabled = false;
            this.InfoText.FlatAppearance.BorderSize = 0;
            this.InfoText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InfoText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InfoText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoText.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoText.ForeColor = System.Drawing.Color.Black;
            this.InfoText.Location = new System.Drawing.Point(1, 0);
            this.InfoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(648, 287);
            this.InfoText.TabIndex = 0;
            this.InfoText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InfoText.UseVisualStyleBackColor = false;
            // 
            // AddressText
            // 
            this.AddressText.AutoSize = true;
            this.AddressText.BackColor = System.Drawing.SystemColors.Menu;
            this.AddressText.Location = new System.Drawing.Point(26, 327);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(0, 18);
            this.AddressText.TabIndex = 1;
            // 
            // PhoneText
            // 
            this.PhoneText.AutoSize = true;
            this.PhoneText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.Location = new System.Drawing.Point(26, 358);
            this.PhoneText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(0, 18);
            this.PhoneText.TabIndex = 1;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 433);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.InfoText);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InfoText;
        private System.Windows.Forms.Label AddressText;
        private System.Windows.Forms.Label PhoneText;
    }
}
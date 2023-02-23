namespace BookOfShadows
{
    partial class reset_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reset_password));
            this.resetLabel = new System.Windows.Forms.Label();
            this.resetTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.resetLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetLabel.Image = ((System.Drawing.Image)(resources.GetObject("resetLabel.Image")));
            this.resetLabel.Location = new System.Drawing.Point(122, 27);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(295, 65);
            this.resetLabel.TabIndex = 0;
            this.resetLabel.Text = "Reset Password";
            // 
            // resetTextBox
            // 
            this.resetTextBox.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.resetTextBox.Location = new System.Drawing.Point(122, 125);
            this.resetTextBox.Name = "resetTextBox";
            this.resetTextBox.Size = new System.Drawing.Size(284, 37);
            this.resetTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(163, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resetTextBox);
            this.Controls.Add(this.resetLabel);
            this.Name = "reset_password";
            this.Text = "reset_password";
            this.Load += new System.EventHandler(this.reset_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label resetLabel;
        private TextBox resetTextBox;
        private Button button1;
    }
}
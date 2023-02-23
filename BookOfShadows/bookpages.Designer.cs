namespace BookOfShadows
{
    partial class insideBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insideBook));
            this.tableofcontents = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBody = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.enterTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableofcontents
            // 
            this.tableofcontents.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.tableofcontents.AutoSize = true;
            this.tableofcontents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableofcontents.Enabled = false;
            this.tableofcontents.Font = new System.Drawing.Font("Viner Hand ITC", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tableofcontents.Location = new System.Drawing.Point(244, 33);
            this.tableofcontents.Name = "tableofcontents";
            this.tableofcontents.Size = new System.Drawing.Size(381, 71);
            this.tableofcontents.TabIndex = 0;
            this.tableofcontents.Tag = "";
            this.tableofcontents.Text = "Table of Contents";
            // 
            // title
            // 
            this.title.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.title.Font = new System.Drawing.Font("Viner Hand ITC", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(790, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(587, 71);
            this.title.TabIndex = 1;
            this.title.Tag = "";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // inputTitle
            // 
            this.inputTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.inputTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTitle.Font = new System.Drawing.Font("Viner Hand ITC", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.inputTitle.Location = new System.Drawing.Point(807, 39);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTitle.Size = new System.Drawing.Size(570, 72);
            this.inputTitle.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(160, 194);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(531, 511);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.resetButton.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(1078, 814);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(310, 50);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset Password";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(803, 816);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBody
            // 
            this.textBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBody.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBody.Location = new System.Drawing.Point(808, 167);
            this.textBody.Name = "textBody";
            this.textBody.Size = new System.Drawing.Size(562, 621);
            this.textBody.TabIndex = 6;
            this.textBody.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.saveButton.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(937, 816);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 48);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.titleTextBox.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.titleTextBox.Location = new System.Drawing.Point(160, 833);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(392, 46);
            this.titleTextBox.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchButton.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(593, 835);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 44);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // enterTitleLabel
            // 
            this.enterTitleLabel.AutoSize = true;
            this.enterTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.enterTitleLabel.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.enterTitleLabel.Location = new System.Drawing.Point(273, 749);
            this.enterTitleLabel.Name = "enterTitleLabel";
            this.enterTitleLabel.Size = new System.Drawing.Size(201, 39);
            this.enterTitleLabel.TabIndex = 10;
            this.enterTitleLabel.Text = "Enter Spell Title";
            // 
            // insideBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1507, 934);
            this.Controls.Add(this.enterTitleLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBody);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tableofcontents);
            this.Name = "insideBook";
            this.Load += new System.EventHandler(this.bookpages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tableofcontents;
        private Label title;
        private TextBox inputTitle;
        private RichTextBox richTextBox1;
        private Button resetButton;
        private Button button1;
        private RichTextBox textBody;
        private Button saveButton;
        private TextBox titleTextBox;
        private Button searchButton;
        private Label enterTitleLabel;
    }
}
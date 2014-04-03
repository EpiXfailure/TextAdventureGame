namespace TextAdventure
{
    partial class Form1
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
            this.Dialogue = new System.Windows.Forms.RichTextBox();
            this.Hero_stats = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.talk = new System.Windows.Forms.Button();
            this.Examine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dialogue
            // 
            this.Dialogue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dialogue.Location = new System.Drawing.Point(241, 12);
            this.Dialogue.Name = "Dialogue";
            this.Dialogue.Size = new System.Drawing.Size(520, 274);
            this.Dialogue.TabIndex = 1;
            this.Dialogue.Text = "";
            // 
            // Hero_stats
            // 
            this.Hero_stats.FormattingEnabled = true;
            this.Hero_stats.Location = new System.Drawing.Point(12, 12);
            this.Hero_stats.Name = "Hero_stats";
            this.Hero_stats.Size = new System.Drawing.Size(149, 277);
            this.Hero_stats.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "New Character";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // talk
            // 
            this.talk.Location = new System.Drawing.Point(241, 326);
            this.talk.Name = "talk";
            this.talk.Size = new System.Drawing.Size(75, 23);
            this.talk.TabIndex = 4;
            this.talk.Text = "talk";
            this.talk.UseVisualStyleBackColor = true;
            this.talk.Click += new System.EventHandler(this.talk_Click);
            // 
            // Examine
            // 
            this.Examine.Location = new System.Drawing.Point(338, 326);
            this.Examine.Name = "Examine";
            this.Examine.Size = new System.Drawing.Size(75, 23);
            this.Examine.TabIndex = 5;
            this.Examine.Text = "Examine";
            this.Examine.UseVisualStyleBackColor = true;
            this.Examine.Click += new System.EventHandler(this.Examine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 489);
            this.Controls.Add(this.Examine);
            this.Controls.Add(this.talk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hero_stats);
            this.Controls.Add(this.Dialogue);
            this.Name = "Form1";
            this.Text = "TextAdventure";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Dialogue;
        private System.Windows.Forms.ListBox Hero_stats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button talk;
        private System.Windows.Forms.Button Examine;
    }
}


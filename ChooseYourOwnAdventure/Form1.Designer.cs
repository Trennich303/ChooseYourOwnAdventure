
namespace ChooseYourOwnAdventure
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
            this.outputText = new System.Windows.Forms.Label();
            this.buttonOption1 = new System.Windows.Forms.Button();
            this.buttonOption2 = new System.Windows.Forms.Button();
            this.labelOption1 = new System.Windows.Forms.Label();
            this.labelOption2 = new System.Windows.Forms.Label();
            this.labelOption3 = new System.Windows.Forms.Label();
            this.buttonOption3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.Transparent;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.ForeColor = System.Drawing.Color.Snow;
            this.outputText.Location = new System.Drawing.Point(28, 9);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(760, 235);
            this.outputText.TabIndex = 1;
            this.outputText.Click += new System.EventHandler(this.outputText_Click);
            // 
            // buttonOption1
            // 
            this.buttonOption1.BackColor = System.Drawing.Color.DarkGray;
            this.buttonOption1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOption1.Location = new System.Drawing.Point(33, 290);
            this.buttonOption1.Name = "buttonOption1";
            this.buttonOption1.Size = new System.Drawing.Size(86, 58);
            this.buttonOption1.TabIndex = 2;
            this.buttonOption1.UseVisualStyleBackColor = false;
            this.buttonOption1.Click += new System.EventHandler(this.buttonOption1_Click);
            // 
            // buttonOption2
            // 
            this.buttonOption2.BackColor = System.Drawing.Color.DarkGray;
            this.buttonOption2.BackgroundImage = global::ChooseYourOwnAdventure.Properties.Resources._24_512;
            this.buttonOption2.Location = new System.Drawing.Point(33, 369);
            this.buttonOption2.Name = "buttonOption2";
            this.buttonOption2.Size = new System.Drawing.Size(86, 54);
            this.buttonOption2.TabIndex = 3;
            this.buttonOption2.UseVisualStyleBackColor = false;
            this.buttonOption2.Click += new System.EventHandler(this.buttonOption2_Click);
            // 
            // labelOption1
            // 
            this.labelOption1.AutoSize = true;
            this.labelOption1.BackColor = System.Drawing.Color.Transparent;
            this.labelOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption1.ForeColor = System.Drawing.Color.White;
            this.labelOption1.Location = new System.Drawing.Point(147, 304);
            this.labelOption1.Name = "labelOption1";
            this.labelOption1.Size = new System.Drawing.Size(106, 29);
            this.labelOption1.TabIndex = 4;
            this.labelOption1.Text = "Go right";
            // 
            // labelOption2
            // 
            this.labelOption2.AutoSize = true;
            this.labelOption2.BackColor = System.Drawing.Color.Transparent;
            this.labelOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption2.ForeColor = System.Drawing.Color.White;
            this.labelOption2.Location = new System.Drawing.Point(147, 381);
            this.labelOption2.Name = "labelOption2";
            this.labelOption2.Size = new System.Drawing.Size(90, 29);
            this.labelOption2.TabIndex = 5;
            this.labelOption2.Text = "Go left";
            // 
            // labelOption3
            // 
            this.labelOption3.BackColor = System.Drawing.Color.Transparent;
            this.labelOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption3.ForeColor = System.Drawing.Color.White;
            this.labelOption3.Location = new System.Drawing.Point(147, 235);
            this.labelOption3.Name = "labelOption3";
            this.labelOption3.Size = new System.Drawing.Size(106, 29);
            this.labelOption3.TabIndex = 6;
            // 
            // buttonOption3
            // 
            this.buttonOption3.BackColor = System.Drawing.Color.DarkGray;
            this.buttonOption3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOption3.Location = new System.Drawing.Point(33, 221);
            this.buttonOption3.Name = "buttonOption3";
            this.buttonOption3.Size = new System.Drawing.Size(86, 58);
            this.buttonOption3.TabIndex = 7;
            this.buttonOption3.UseVisualStyleBackColor = false;
            this.buttonOption3.Visible = false;
            this.buttonOption3.Click += new System.EventHandler(this.buttonOption3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChooseYourOwnAdventure.Properties.Resources.amazon_rainforest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOption3);
            this.Controls.Add(this.labelOption3);
            this.Controls.Add(this.labelOption2);
            this.Controls.Add(this.labelOption1);
            this.Controls.Add(this.buttonOption2);
            this.Controls.Add(this.buttonOption1);
            this.Controls.Add(this.outputText);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.Button buttonOption1;
        private System.Windows.Forms.Button buttonOption2;
        private System.Windows.Forms.Label labelOption1;
        private System.Windows.Forms.Label labelOption2;
        private System.Windows.Forms.Label labelOption3;
        private System.Windows.Forms.Button buttonOption3;
    }
}


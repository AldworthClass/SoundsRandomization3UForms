namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgCat = new System.Windows.Forms.PictureBox();
            this.imgDog = new System.Windows.Forms.PictureBox();
            this.imgPig = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPig)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCat
            // 
            this.imgCat.Enabled = false;
            this.imgCat.Image = ((System.Drawing.Image)(resources.GetObject("imgCat.Image")));
            this.imgCat.Location = new System.Drawing.Point(21, 68);
            this.imgCat.Name = "imgCat";
            this.imgCat.Size = new System.Drawing.Size(196, 188);
            this.imgCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCat.TabIndex = 0;
            this.imgCat.TabStop = false;
            this.imgCat.Click += new System.EventHandler(this.imgCat_Click);
            // 
            // imgDog
            // 
            this.imgDog.Enabled = false;
            this.imgDog.Image = ((System.Drawing.Image)(resources.GetObject("imgDog.Image")));
            this.imgDog.Location = new System.Drawing.Point(400, 68);
            this.imgDog.Name = "imgDog";
            this.imgDog.Size = new System.Drawing.Size(187, 190);
            this.imgDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDog.TabIndex = 1;
            this.imgDog.TabStop = false;
            this.imgDog.Click += new System.EventHandler(this.imgDog_Click);
            // 
            // imgPig
            // 
            this.imgPig.Enabled = false;
            this.imgPig.Image = ((System.Drawing.Image)(resources.GetObject("imgPig.Image")));
            this.imgPig.Location = new System.Drawing.Point(223, 68);
            this.imgPig.Name = "imgPig";
            this.imgPig.Size = new System.Drawing.Size(171, 189);
            this.imgPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPig.TabIndex = 2;
            this.imgPig.TabStop = false;
            this.imgPig.Click += new System.EventHandler(this.imgPig_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(400, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(187, 40);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play Sound";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(28, 15);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(354, 24);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Play the sound, guess the correct animal.";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(28, 286);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(65, 24);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 343);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.imgPig);
            this.Controls.Add(this.imgDog);
            this.Controls.Add(this.imgCat);
            this.Name = "Form1";
            this.Text = "Sounds, Counting and Random Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.imgCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCat;
        private System.Windows.Forms.PictureBox imgDog;
        private System.Windows.Forms.PictureBox imgPig;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblResults;
    }
}


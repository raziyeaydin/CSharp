namespace insKay
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_personelkayıt = new System.Windows.Forms.Button();
            this.btn_personelarama = new System.Windows.Forms.Button();
            this.btn_elemanarama = new System.Windows.Forms.Button();
            this.btn_cv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::insKay.Properties.Resources.mc_isyankar47;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_personelkayıt
            // 
            this.btn_personelkayıt.BackColor = System.Drawing.Color.White;
            this.btn_personelkayıt.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personelkayıt.Location = new System.Drawing.Point(52, 57);
            this.btn_personelkayıt.Name = "btn_personelkayıt";
            this.btn_personelkayıt.Size = new System.Drawing.Size(80, 44);
            this.btn_personelkayıt.TabIndex = 2;
            this.btn_personelkayıt.Text = "Personel Kayıt";
            this.btn_personelkayıt.UseVisualStyleBackColor = false;
            this.btn_personelkayıt.Click += new System.EventHandler(this.btn_personelkayıt_Click);
            // 
            // btn_personelarama
            // 
            this.btn_personelarama.BackColor = System.Drawing.Color.White;
            this.btn_personelarama.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personelarama.Location = new System.Drawing.Point(232, 57);
            this.btn_personelarama.Name = "btn_personelarama";
            this.btn_personelarama.Size = new System.Drawing.Size(80, 44);
            this.btn_personelarama.TabIndex = 3;
            this.btn_personelarama.Text = "Personel Arama";
            this.btn_personelarama.UseVisualStyleBackColor = false;
            this.btn_personelarama.Click += new System.EventHandler(this.btn_personelarama_Click);
            // 
            // btn_elemanarama
            // 
            this.btn_elemanarama.BackColor = System.Drawing.Color.White;
            this.btn_elemanarama.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_elemanarama.Location = new System.Drawing.Point(232, 191);
            this.btn_elemanarama.Name = "btn_elemanarama";
            this.btn_elemanarama.Size = new System.Drawing.Size(80, 44);
            this.btn_elemanarama.TabIndex = 4;
            this.btn_elemanarama.Text = "Eleman Arama";
            this.btn_elemanarama.UseVisualStyleBackColor = false;
            this.btn_elemanarama.Click += new System.EventHandler(this.btn_elemanarama_Click);
            // 
            // btn_cv
            // 
            this.btn_cv.BackColor = System.Drawing.Color.White;
            this.btn_cv.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cv.Location = new System.Drawing.Point(52, 191);
            this.btn_cv.Name = "btn_cv";
            this.btn_cv.Size = new System.Drawing.Size(80, 44);
            this.btn_cv.TabIndex = 5;
            this.btn_cv.Text = "CV";
            this.btn_cv.UseVisualStyleBackColor = false;
            this.btn_cv.Click += new System.EventHandler(this.btn_cv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(359, 296);
            this.Controls.Add(this.btn_cv);
            this.Controls.Add(this.btn_elemanarama);
            this.Controls.Add(this.btn_personelarama);
            this.Controls.Add(this.btn_personelkayıt);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_personelkayıt;
        private System.Windows.Forms.Button btn_personelarama;
        private System.Windows.Forms.Button btn_elemanarama;
        private System.Windows.Forms.Button btn_cv;
    }
}


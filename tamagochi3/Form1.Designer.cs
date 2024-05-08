namespace tamagochi3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taille = new System.Windows.Forms.Label();
            this.satisfaction = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jouer = new System.Windows.Forms.Button();
            this.nourrir = new System.Windows.Forms.Button();
            this.travailler = new System.Windows.Forms.Button();
            this.gronder = new System.Windows.Forms.Button();
            this.dormir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taille);
            this.groupBox1.Controls.Add(this.satisfaction);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "stats";
            // 
            // taille
            // 
            this.taille.Location = new System.Drawing.Point(115, 51);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(85, 23);
            this.taille.TabIndex = 3;
            this.taille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // satisfaction
            // 
            this.satisfaction.Location = new System.Drawing.Point(115, 28);
            this.satisfaction.Name = "satisfaction";
            this.satisfaction.Size = new System.Drawing.Size(85, 23);
            this.satisfaction.TabIndex = 2;
            this.satisfaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "taille";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "satisfaction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // jouer
            // 
            this.jouer.Location = new System.Drawing.Point(227, 15);
            this.jouer.Name = "jouer";
            this.jouer.Size = new System.Drawing.Size(127, 32);
            this.jouer.TabIndex = 2;
            this.jouer.Text = "jouer";
            this.jouer.UseVisualStyleBackColor = true;
            this.jouer.Click += new System.EventHandler(this.jouer_Click);
            // 
            // nourrir
            // 
            this.nourrir.Location = new System.Drawing.Point(227, 57);
            this.nourrir.Name = "nourrir";
            this.nourrir.Size = new System.Drawing.Size(127, 32);
            this.nourrir.TabIndex = 3;
            this.nourrir.Text = "nourrir";
            this.nourrir.UseVisualStyleBackColor = true;
            this.nourrir.Click += new System.EventHandler(this.nourrir_Click);
            // 
            // travailler
            // 
            this.travailler.Location = new System.Drawing.Point(227, 141);
            this.travailler.Name = "travailler";
            this.travailler.Size = new System.Drawing.Size(127, 32);
            this.travailler.TabIndex = 5;
            this.travailler.Text = "travailler";
            this.travailler.UseVisualStyleBackColor = true;
            this.travailler.Click += new System.EventHandler(this.travailler_Click);
            // 
            // gronder
            // 
            this.gronder.Location = new System.Drawing.Point(227, 99);
            this.gronder.Name = "gronder";
            this.gronder.Size = new System.Drawing.Size(127, 32);
            this.gronder.TabIndex = 4;
            this.gronder.Text = "gronder";
            this.gronder.UseVisualStyleBackColor = true;
            this.gronder.Click += new System.EventHandler(this.gronder_Click);
            // 
            // dormir
            // 
            this.dormir.Location = new System.Drawing.Point(227, 183);
            this.dormir.Name = "dormir";
            this.dormir.Size = new System.Drawing.Size(127, 32);
            this.dormir.TabIndex = 6;
            this.dormir.Text = "dormir";
            this.dormir.UseVisualStyleBackColor = true;
            this.dormir.Click += new System.EventHandler(this.dormir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 376);
            this.Controls.Add(this.dormir);
            this.Controls.Add(this.travailler);
            this.Controls.Add(this.gronder);
            this.Controls.Add(this.nourrir);
            this.Controls.Add(this.jouer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label taille;
        private System.Windows.Forms.Label satisfaction;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button jouer;
        private System.Windows.Forms.Button nourrir;
        private System.Windows.Forms.Button travailler;
        private System.Windows.Forms.Button gronder;
        private System.Windows.Forms.Button dormir;

        #endregion
    }
}
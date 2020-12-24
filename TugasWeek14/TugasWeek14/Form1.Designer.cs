namespace TugasWeek14
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
            this.labelKalimat = new System.Windows.Forms.Label();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.textBoxHuruf = new System.Windows.Forms.TextBox();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.textBoxMenjadi = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKalimat.Location = new System.Drawing.Point(23, 79);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(138, 20);
            this.labelKalimat.TabIndex = 0;
            this.labelKalimat.Text = "Masukkan Kalimat";
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKalimat.Location = new System.Drawing.Point(168, 78);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(250, 26);
            this.textBoxKalimat.TabIndex = 1;
            this.textBoxKalimat.TextChanged += new System.EventHandler(this.textBoxKalimat_TextChanged);
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuruf.Location = new System.Drawing.Point(23, 131);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(126, 20);
            this.labelHuruf.TabIndex = 2;
            this.labelHuruf.Text = "Masukkan Huruf";
            // 
            // textBoxHuruf
            // 
            this.textBoxHuruf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHuruf.Location = new System.Drawing.Point(168, 130);
            this.textBoxHuruf.Name = "textBoxHuruf";
            this.textBoxHuruf.Size = new System.Drawing.Size(58, 26);
            this.textBoxHuruf.TabIndex = 3;
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenjadi.Location = new System.Drawing.Point(265, 133);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(64, 20);
            this.labelMenjadi.TabIndex = 4;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // textBoxMenjadi
            // 
            this.textBoxMenjadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMenjadi.Location = new System.Drawing.Point(360, 128);
            this.textBoxMenjadi.Name = "textBoxMenjadi";
            this.textBoxMenjadi.Size = new System.Drawing.Size(58, 26);
            this.textBoxMenjadi.TabIndex = 5;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonversi.Location = new System.Drawing.Point(168, 179);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(250, 27);
            this.buttonKonversi.TabIndex = 6;
            this.buttonKonversi.Text = "Konversikan!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasil.Location = new System.Drawing.Point(27, 257);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(44, 20);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(164, 257);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(57, 20);
            this.labelOutput.TabIndex = 8;
            this.labelOutput.Text = "label1";
            this.labelOutput.Visible = false;
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxMenjadi);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.textBoxHuruf);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.labelKalimat);
            this.Name = "Form1";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKalimat;
        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.TextBox textBoxHuruf;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.TextBox textBoxMenjadi;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelOutput;
    }
}


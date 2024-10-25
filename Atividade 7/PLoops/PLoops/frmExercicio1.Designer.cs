namespace PLoops
{
    partial class frmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnParLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(199, 46);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(317, 130);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Location = new System.Drawing.Point(130, 230);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(75, 47);
            this.btnEspacoBranco.TabIndex = 1;
            this.btnEspacoBranco.Text = "N° Espaço Branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(312, 229);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(75, 23);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Letra R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnParLetras
            // 
            this.btnParLetras.Location = new System.Drawing.Point(527, 229);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(75, 48);
            this.btnParLetras.TabIndex = 3;
            this.btnParLetras.Text = "Par de Letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            this.btnParLetras.Click += new System.EventHandler(this.btnParLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnParLetras;
    }
}
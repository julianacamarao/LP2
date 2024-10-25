namespace PLoops
{
    partial class frmExercicio2
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(32, 33);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(689, 13);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Fazer um Programa para gerar o número H. O número N seráa fornecido abaixo. O res" +
    "ultado será no formato: H = 1 + 1/2 +1/3+1/4+1/5+...+1/N";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(207, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(179, 211);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcular;
    }
}
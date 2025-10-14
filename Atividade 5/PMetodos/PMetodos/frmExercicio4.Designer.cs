namespace PMetodos
{
    partial class frmExercicio4
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
            this.btnContaNum = new System.Windows.Forms.Button();
            this.btnContarLetra = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnContaNum
            // 
            this.btnContaNum.Location = new System.Drawing.Point(108, 120);
            this.btnContaNum.Name = "btnContaNum";
            this.btnContaNum.Size = new System.Drawing.Size(156, 109);
            this.btnContaNum.TabIndex = 0;
            this.btnContaNum.Text = "Contar Numeros";
            this.btnContaNum.UseVisualStyleBackColor = true;
            this.btnContaNum.Click += new System.EventHandler(this.btnContaNum_Click);
            // 
            // btnContarLetra
            // 
            this.btnContarLetra.Location = new System.Drawing.Point(459, 120);
            this.btnContarLetra.Name = "btnContarLetra";
            this.btnContarLetra.Size = new System.Drawing.Size(156, 109);
            this.btnContarLetra.TabIndex = 1;
            this.btnContarLetra.Text = "Contar Letras";
            this.btnContarLetra.UseVisualStyleBackColor = true;
            this.btnContarLetra.Click += new System.EventHandler(this.btnContarLetra_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(286, 120);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(156, 109);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Posição 1º Caracter Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(108, 18);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(507, 96);
            this.rchtxtFrase.TabIndex = 3;
            this.rchtxtFrase.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchtxtFrase);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnContarLetra);
            this.Controls.Add(this.btnContaNum);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContaNum;
        private System.Windows.Forms.Button btnContarLetra;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.RichTextBox rchtxtFrase;
    }
}
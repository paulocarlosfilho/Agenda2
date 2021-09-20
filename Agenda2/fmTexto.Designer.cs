
namespace Agenda2
{
    partial class fmTexto
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_texto = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cndPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Termo de pesquisa";
            // 
            // text_texto
            // 
            this.text_texto.BackColor = System.Drawing.SystemColors.MenuText;
            this.text_texto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.text_texto.Location = new System.Drawing.Point(36, 73);
            this.text_texto.MaxLength = 30;
            this.text_texto.Name = "text_texto";
            this.text_texto.Size = new System.Drawing.Size(211, 23);
            this.text_texto.TabIndex = 0;
            this.text_texto.TextChanged += new System.EventHandler(this.text_texto_TextChanged);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(50, 132);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(81, 34);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cndPesquisar
            // 
            this.cndPesquisar.Location = new System.Drawing.Point(150, 132);
            this.cndPesquisar.Name = "cndPesquisar";
            this.cndPesquisar.Size = new System.Drawing.Size(81, 34);
            this.cndPesquisar.TabIndex = 1;
            this.cndPesquisar.Text = "Pesquisar";
            this.cndPesquisar.UseVisualStyleBackColor = true;
            this.cndPesquisar.Click += new System.EventHandler(this.cndPesquisar_Click);
            // 
            // fmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.ControlBox = false;
            this.Controls.Add(this.cndPesquisar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.text_texto);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_texto;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cndPesquisar;
    }
}
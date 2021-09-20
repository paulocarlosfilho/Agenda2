
namespace Agenda2
{
    partial class fmResultados
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
            this.cmd_nova_pesquisa = new System.Windows.Forms.Button();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.lista_final = new System.Windows.Forms.ListBox();
            this.numeroRegistros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_nova_pesquisa
            // 
            this.cmd_nova_pesquisa.Location = new System.Drawing.Point(195, 167);
            this.cmd_nova_pesquisa.Name = "cmd_nova_pesquisa";
            this.cmd_nova_pesquisa.Size = new System.Drawing.Size(154, 34);
            this.cmd_nova_pesquisa.TabIndex = 3;
            this.cmd_nova_pesquisa.Text = "Nova Pesquisa...";
            this.cmd_nova_pesquisa.UseVisualStyleBackColor = true;
            this.cmd_nova_pesquisa.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(355, 167);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(154, 34);
            this.cmd_fechar.TabIndex = 4;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista_final
            // 
            this.lista_final.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lista_final.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lista_final.FormattingEnabled = true;
            this.lista_final.ItemHeight = 15;
            this.lista_final.Location = new System.Drawing.Point(0, 1);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(523, 139);
            this.lista_final.TabIndex = 5;
            // 
            // numeroRegistros
            // 
            this.numeroRegistros.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numeroRegistros.Location = new System.Drawing.Point(0, 173);
            this.numeroRegistros.Name = "numeroRegistros";
            this.numeroRegistros.Size = new System.Drawing.Size(189, 23);
            this.numeroRegistros.TabIndex = 10;
            this.numeroRegistros.Text = "Registros 0";
            this.numeroRegistros.Click += new System.EventHandler(this.numeroRegistros_Click);
            // 
            // fmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(535, 234);
            this.ControlBox = false;
            this.Controls.Add(this.numeroRegistros);
            this.Controls.Add(this.lista_final);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.cmd_nova_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.fmResultados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_nova_pesquisa;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.ListBox lista_final;
        private System.Windows.Forms.Label numeroRegistros;
    }
}
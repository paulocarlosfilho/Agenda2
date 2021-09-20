
namespace Agenda2
{
    partial class fmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmdInserirEditar = new System.Windows.Forms.Button();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(277, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda";
            // 
            // cmdInserirEditar
            // 
            this.cmdInserirEditar.Location = new System.Drawing.Point(299, 137);
            this.cmdInserirEditar.Name = "cmdInserirEditar";
            this.cmdInserirEditar.Size = new System.Drawing.Size(154, 34);
            this.cmdInserirEditar.TabIndex = 1;
            this.cmdInserirEditar.Text = "Inserir/Editar";
            this.cmdInserirEditar.UseVisualStyleBackColor = true;
            this.cmdInserirEditar.Click += new System.EventHandler(this.cmd_inserir_Click);
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(299, 202);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(154, 34);
            this.cmd_pesquisar.TabIndex = 2;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmdSair.Location = new System.Drawing.Point(299, 267);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(154, 34);
            this.cmdSair.TabIndex = 3;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = false;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click_1);
            // 
            // label_versao
            // 
            this.label_versao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_versao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_versao.Location = new System.Drawing.Point(12, 381);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(728, 23);
            this.label_versao.TabIndex = 4;
            this.label_versao.Text = "Apresentação do projeto";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.cmdInserirEditar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMenu";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdInserirEditar;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Label label_versao;
    }
}



namespace Agenda2
{
    partial class fmInserirEditar
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
            this.cmdFechar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.Label();
            this.textNome1 = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.cmdTel = new System.Windows.Forms.Label();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.listaContatos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroRegistros = new System.Windows.Forms.Label();
            this.cmdApagar = new System.Windows.Forms.Button();
            this.cmdEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdFechar
            // 
            this.cmdFechar.Location = new System.Drawing.Point(696, 393);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(75, 23);
            this.cmdFechar.TabIndex = 6;
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // textNome
            // 
            this.textNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textNome.Location = new System.Drawing.Point(12, 21);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(58, 23);
            this.textNome.TabIndex = 7;
            this.textNome.Text = "Nome: ";
            this.textNome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.textNome.Click += new System.EventHandler(this.textNome_Click);
            // 
            // textNome1
            // 
            this.textNome1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textNome1.Location = new System.Drawing.Point(76, 18);
            this.textNome1.MaxLength = 50;
            this.textNome1.Name = "textNome1";
            this.textNome1.Size = new System.Drawing.Size(252, 23);
            this.textNome1.TabIndex = 1;
            this.textNome1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textTel
            // 
            this.textTel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textTel.Location = new System.Drawing.Point(76, 58);
            this.textTel.MaxLength = 10;
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(129, 23);
            this.textTel.TabIndex = 2;
            // 
            // cmdTel
            // 
            this.cmdTel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdTel.Location = new System.Drawing.Point(24, 61);
            this.cmdTel.Name = "cmdTel";
            this.cmdTel.Size = new System.Drawing.Size(46, 23);
            this.cmdTel.TabIndex = 8;
            this.cmdTel.Text = "Tel";
            this.cmdTel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdGravar
            // 
            this.cmdGravar.Location = new System.Drawing.Point(363, 177);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(75, 23);
            this.cmdGravar.TabIndex = 3;
            this.cmdGravar.Text = "Gravar";
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // listaContatos
            // 
            this.listaContatos.FormattingEnabled = true;
            this.listaContatos.ItemHeight = 15;
            this.listaContatos.Location = new System.Drawing.Point(97, 251);
            this.listaContatos.Name = "listaContatos";
            this.listaContatos.Size = new System.Drawing.Size(539, 169);
            this.listaContatos.TabIndex = 6;
            this.listaContatos.SelectedIndexChanged += new System.EventHandler(this.listaContatos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(97, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de Contatos Registrados";
            // 
            // numeroRegistros
            // 
            this.numeroRegistros.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numeroRegistros.Location = new System.Drawing.Point(97, 423);
            this.numeroRegistros.Name = "numeroRegistros";
            this.numeroRegistros.Size = new System.Drawing.Size(181, 23);
            this.numeroRegistros.TabIndex = 9;
            this.numeroRegistros.Text = "Registros 0";
            // 
            // cmdApagar
            // 
            this.cmdApagar.Location = new System.Drawing.Point(696, 332);
            this.cmdApagar.Name = "cmdApagar";
            this.cmdApagar.Size = new System.Drawing.Size(75, 23);
            this.cmdApagar.TabIndex = 5;
            this.cmdApagar.Text = "Apagar";
            this.cmdApagar.UseVisualStyleBackColor = true;
            this.cmdApagar.Click += new System.EventHandler(this.cmdApagar_Click);
            // 
            // cmdEditar
            // 
            this.cmdEditar.Location = new System.Drawing.Point(696, 265);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(75, 23);
            this.cmdEditar.TabIndex = 4;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.UseVisualStyleBackColor = true;
            // 
            // fmInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.cmdApagar);
            this.Controls.Add(this.numeroRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaContatos);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.cmdTel);
            this.Controls.Add(this.textNome1);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.cmdFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmInserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Inserir / Editar";
            this.Load += new System.EventHandler(this.fmInserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.Label textNome;
        private System.Windows.Forms.TextBox textNome1;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label cmdTel;
        private System.Windows.Forms.Button cmdGravar;
        private System.Windows.Forms.ListBox listaContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numeroRegistros;
        private System.Windows.Forms.Button cmdApagar;
        private System.Windows.Forms.Button cmdEditar;
    }
}
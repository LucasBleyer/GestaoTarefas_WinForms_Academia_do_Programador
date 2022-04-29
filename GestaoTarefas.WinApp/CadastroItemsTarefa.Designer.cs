namespace GestaoTarefas.WinApp
{
    partial class CadastroItemsTarefa
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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTituloItem = new System.Windows.Forms.TextBox();
            this.listItemsTarefas = new System.Windows.Forms.ListBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tituloTarefa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancelar.Location = new System.Drawing.Point(309, 231);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 40);
            this.bt_cancelar.TabIndex = 7;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_gravar
            // 
            this.bt_gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_gravar.Location = new System.Drawing.Point(228, 231);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(75, 40);
            this.bt_gravar.TabIndex = 6;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Título: ";
            // 
            // txtTituloItem
            // 
            this.txtTituloItem.Location = new System.Drawing.Point(51, 52);
            this.txtTituloItem.Name = "txtTituloItem";
            this.txtTituloItem.Size = new System.Drawing.Size(252, 23);
            this.txtTituloItem.TabIndex = 9;
            // 
            // listItemsTarefas
            // 
            this.listItemsTarefas.FormattingEnabled = true;
            this.listItemsTarefas.ItemHeight = 15;
            this.listItemsTarefas.Location = new System.Drawing.Point(11, 86);
            this.listItemsTarefas.Name = "listItemsTarefas";
            this.listItemsTarefas.Size = new System.Drawing.Size(371, 139);
            this.listItemsTarefas.TabIndex = 10;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(309, 50);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(75, 25);
            this.bt_adicionar.TabIndex = 11;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tarefa: ";
            // 
            // lb_tituloTarefa
            // 
            this.lb_tituloTarefa.AutoSize = true;
            this.lb_tituloTarefa.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tituloTarefa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_tituloTarefa.Location = new System.Drawing.Point(61, 19);
            this.lb_tituloTarefa.Name = "lb_tituloTarefa";
            this.lb_tituloTarefa.Size = new System.Drawing.Size(96, 15);
            this.lb_tituloTarefa.TabIndex = 13;
            this.lb_tituloTarefa.Text = "[Título Tarefa]";
            // 
            // CadastroItemsTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 283);
            this.Controls.Add(this.lb_tituloTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.listItemsTarefas);
            this.Controls.Add(this.txtTituloItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_gravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItemsTarefa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Items da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTituloItem;
        private System.Windows.Forms.ListBox listItemsTarefas;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tituloTarefa;
    }
}
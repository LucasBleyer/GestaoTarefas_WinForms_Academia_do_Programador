namespace GestaoTarefas.WinApp
{
    partial class ListagemTarefas
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
            this.bt_inserir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.listTarefas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(12, 23);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(75, 40);
            this.bt_inserir.TabIndex = 0;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(124, 23);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 40);
            this.bt_editar.TabIndex = 1;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(234, 23);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 40);
            this.bt_excluir.TabIndex = 2;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(345, 23);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(99, 40);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.Text = "Cadastrar Itens";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(477, 23);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(95, 40);
            this.bt_atualizar.TabIndex = 4;
            this.bt_atualizar.Text = "Atualizar Itens";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            // 
            // listTarefas
            // 
            this.listTarefas.FormattingEnabled = true;
            this.listTarefas.ItemHeight = 15;
            this.listTarefas.Location = new System.Drawing.Point(12, 83);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(560, 244);
            this.listTarefas.TabIndex = 5;
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 350);
            this.Controls.Add(this.listTarefas);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListagemTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Tarefas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.ListBox listTarefas;
    }
}

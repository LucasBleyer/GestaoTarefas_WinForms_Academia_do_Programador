namespace GestaoTarefas.WinApp
{
    partial class AtualizaItemsTarefa
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
            this.listItemsTarefa = new System.Windows.Forms.CheckedListBox();
            this.lb_tituloTarefa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listItemsTarefa
            // 
            this.listItemsTarefa.FormattingEnabled = true;
            this.listItemsTarefa.Location = new System.Drawing.Point(7, 59);
            this.listItemsTarefa.Name = "listItemsTarefa";
            this.listItemsTarefa.Size = new System.Drawing.Size(378, 166);
            this.listItemsTarefa.TabIndex = 0;
            // 
            // lb_tituloTarefa
            // 
            this.lb_tituloTarefa.AutoSize = true;
            this.lb_tituloTarefa.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tituloTarefa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_tituloTarefa.Location = new System.Drawing.Point(62, 20);
            this.lb_tituloTarefa.Name = "lb_tituloTarefa";
            this.lb_tituloTarefa.Size = new System.Drawing.Size(96, 15);
            this.lb_tituloTarefa.TabIndex = 15;
            this.lb_tituloTarefa.Text = "[Título Tarefa]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tarefa: ";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancelar.Location = new System.Drawing.Point(315, 232);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 40);
            this.bt_cancelar.TabIndex = 17;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_gravar
            // 
            this.bt_gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_gravar.Location = new System.Drawing.Point(234, 232);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(75, 40);
            this.bt_gravar.TabIndex = 16;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.UseVisualStyleBackColor = true;
            // 
            // AtualizaItemsTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 283);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_gravar);
            this.Controls.Add(this.lb_tituloTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listItemsTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AtualizaItemsTarefa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização dos Items das Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listItemsTarefa;
        private System.Windows.Forms.Label lb_tituloTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_gravar;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroTarefas : Form
    {
        private Tarefa novaTarefa;

        public CadastroTarefas()
        {
            InitializeComponent();
        }

        public Tarefa NovaTarefa
        {
            get 
            { 
                return novaTarefa;
            }
            set
            {
                novaTarefa = value;
                txtTitulo.Text = novaTarefa.Titulo;
            }
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            novaTarefa = new Tarefa();

            novaTarefa.Titulo = txtTitulo.Text;
        }
    }
}

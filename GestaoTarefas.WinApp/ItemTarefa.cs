namespace GestaoTarefas.WinApp
{
    public class ItemTarefa
    {
        public string Titulo { get; internal set; }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
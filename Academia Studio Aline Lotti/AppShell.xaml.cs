namespace Academia_Studio_Aline_Lotti
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Cadastro", typeof(Cadastro));
            Routing.RegisterRoute("Senha", typeof(Senha));
            Routing.RegisterRoute("Treinos", typeof(Treinos));
        }
    }
}

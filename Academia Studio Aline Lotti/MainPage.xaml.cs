namespace Academia_Studio_Aline_Lotti
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cadastro());
        }

        private void OnToggleSenhaClicked(object sender, EventArgs e)
        {            
            SenhaEntry.IsPassword = !SenhaEntry.IsPassword;           
            ToggleSenhaButton.Text = SenhaEntry.IsPassword ? "👁" : "🚫";
        }
    }
}

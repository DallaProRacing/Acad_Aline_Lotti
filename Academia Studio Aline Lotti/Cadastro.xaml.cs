namespace Academia_Studio_Aline_Lotti;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
        InitializeComponent();
    }

    private void OnToggleSenhaButton_Clicked(object sender, EventArgs e)
    {
        SenhaEntry.IsPassword = !SenhaEntry.IsPassword;
        ToggleSenhaButton.Text = SenhaEntry.IsPassword ? "??" : "??";
    }

    private void OnToggleConfirmeSenhaButton_Clicked(object sender, EventArgs e)
    {
        ConfirmeSenhaEntry.IsPassword = !ConfirmeSenhaEntry.IsPassword;
        ToggleConfirmeSenhaButton.Text = ConfirmeSenhaEntry.IsPassword ? "??" : "??";
    }   
}
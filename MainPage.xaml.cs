namespace TP1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

	private void OnOkButtonClicked(object sender, EventArgs e)
    {
        if (IdEntry.Text == "admin" && PassEntry.Text == "senha@dmin")
        {
            DisplayAlert("Login", "Logou com sucesso", "OK");
        }
        else
        {
            DisplayAlert("Login", "Login não autorizado", "OK");
        }
    }

	private void OnLimparButtonClicked(object sender, EventArgs e)
    {
        IdEntry.Text = string.Empty;
        PassEntry.Text = string.Empty;

        IdEntry.Focus();
    }

    /// <summary>
    /// Evento disparado ao clicar no botão Créditos.
    /// Exibe os nomes dos autores.
    /// </summary> 
	private async void OnCreditosButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Créditos", "Desenvolvido por:\n\n- Maria Eduarda Fodor - CB3025063\n- Pedro Xavier Oliveira -  CB3027376", "Fechar");
    }
}
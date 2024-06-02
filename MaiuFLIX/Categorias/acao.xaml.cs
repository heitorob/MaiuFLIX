using MaiuFLIX.Filmes.acao;

namespace MaiuFLIX;

public partial class acao : ContentPage
{
	public acao()
	{
		InitializeComponent();
	}

    private void btnacaoi_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new acaoi());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnacaoii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new acaoii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnacaoiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new acaoiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btnacaoiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new acaoiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
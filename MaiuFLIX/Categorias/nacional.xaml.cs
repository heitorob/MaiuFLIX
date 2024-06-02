using MaiuFLIX.Filmes.ncnl;

namespace MaiuFLIX;

public partial class nacional : ContentPage
{
	public nacional()
	{
		InitializeComponent();
	}

    private void btnncnli_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ncnli());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnncnlii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ncnlii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnncnliii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ncnliii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btnncnliv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ncnliv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
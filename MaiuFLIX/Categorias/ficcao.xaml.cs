using MaiuFLIX.Filmes.fcco;

namespace MaiuFLIX;

public partial class ficcao : ContentPage
{
	public ficcao()
	{
		InitializeComponent();
	}

    private void btnfccoi_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new fccoi());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnfccoii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new fccoii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnfccoiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new fccoiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btnfccoiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new fccoiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
using MaiuFLIX.Filmes.rmnc;

namespace MaiuFLIX;

public partial class romance : ContentPage
{
	public romance()
	{
		InitializeComponent();
	}

    private void btnrmnci_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new rmnci());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnrmncii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new rmncii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnrmnciii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new rmnciii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btnrmnciv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new rmnciv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
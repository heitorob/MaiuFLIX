using MaiuFLIX.Filmes.comd;

namespace MaiuFLIX;

public partial class comedia : ContentPage
{
	public comedia()
	{
		InitializeComponent();
	}

    private void btncomdi_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new comdi());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btncomdii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new comdii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btncomdiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new comdiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btncomdiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new comdiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
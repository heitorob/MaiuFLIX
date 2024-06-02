using MaiuFLIX.Filmes.inft;

namespace MaiuFLIX;

public partial class infantil : ContentPage
{
	public infantil()
	{
		InitializeComponent();
	}

    private void btninfti_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new infti());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btninftii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new inftii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btninftiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new inftiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btninftiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new inftiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
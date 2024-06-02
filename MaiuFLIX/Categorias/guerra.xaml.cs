using MaiuFLIX.Filmes.grra;

namespace MaiuFLIX;

public partial class guerra : ContentPage
{
	public guerra()
	{
		InitializeComponent();
	}

    private void btngrrai_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new grrai());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btngrraii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new grraii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btngrraiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new grraiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btngrraiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new grraiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
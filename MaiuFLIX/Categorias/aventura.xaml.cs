using MaiuFLIX.Filmes.avnt;

namespace MaiuFLIX;

public partial class aventura : ContentPage
{
	public aventura()
	{
		InitializeComponent();
	}

    private void btnavnti_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new avnti());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnavntii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new avntii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnavntiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new avntiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btnavntiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new avntiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
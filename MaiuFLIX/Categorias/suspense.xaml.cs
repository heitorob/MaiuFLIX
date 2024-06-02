using MaiuFLIX.Filmes.susp;

namespace MaiuFLIX;

public partial class suspense : ContentPage
{
	public suspense()
	{
		InitializeComponent();
	}

    private void btnsuspi_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new suspi());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnsuspii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new suspii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnsuspiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new suspiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btnsuspiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new suspiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
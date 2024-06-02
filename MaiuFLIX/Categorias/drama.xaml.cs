using MaiuFLIX.Filmes.drma;

namespace MaiuFLIX;

public partial class drama : ContentPage
{
	public drama()
	{
		InitializeComponent();
	}

    private void btndrmai_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new drmai());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btndrmaii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new drmaii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btndrmaiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new drmaiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btndrmaiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new drmaiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
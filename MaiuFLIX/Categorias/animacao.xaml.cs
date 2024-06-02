using MaiuFLIX.Filmes.anim;

namespace MaiuFLIX;

public partial class animacao : ContentPage
{
	public animacao()
	{
		InitializeComponent();
	}

    private void btnanimi_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new animi());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnanimii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new animii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btnanimiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new animiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btnanimiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new animiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
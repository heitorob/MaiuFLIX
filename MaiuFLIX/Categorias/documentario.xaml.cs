using MaiuFLIX.Filmes.dmct;

namespace MaiuFLIX;

public partial class documentario : ContentPage
{
	public documentario()
	{
		InitializeComponent();
	}

    private void btndcmti_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new dmcti());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btndcmtii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new dmctii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void btndcmtiii_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new dmctiii());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void btndcmtiv_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new dmctiv());
        }
        catch
        {
            DisplayAlert("OPS!!", "...", "OK");
        }
    }
}
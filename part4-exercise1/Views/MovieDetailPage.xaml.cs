namespace MovieCatalog.Views;

public partial class MovieDetailPage : ContentPage
{
	public MovieDetailPage(ViewModels.MovieViewModel movie)
	{
		BindingContext = movie;
		InitializeComponent();
	}
    public MovieDetailPage()
    {
        BindingContext = App.MainViewModel.SelectedMovie;
        InitializeComponent();
    }
}
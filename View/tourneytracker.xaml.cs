using BwoodChess.ViewModel;

namespace BwoodChess.View;

public partial class tourneytracker : ContentPage
{
	public tourneytracker()
	{
		InitializeComponent();
		BindingContext = new TourneyTrackerViewModel(Navigation);
	}
}
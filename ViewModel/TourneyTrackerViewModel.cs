using BwoodChess.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BwoodChess.ViewModel
{
    public class TourneyTrackerViewModel:BaseViewModel
    {
        private readonly INavigation _navigation;
        public TourneyTrackerViewModel(INavigation navigation)
        {
            _navigation = navigation;
            MakeNewTourney = new RelayCommand(ShowMakeTourneyWin);

        }

        public ICommand MakeNewTourney { get; }
        private void ShowMakeTourneyWin()
        {
            _navigation.PushAsync(new MakeTourney());
        }
    }
}

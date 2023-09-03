using BwoodChess.ViewModel;
using System.Linq;

namespace BwoodChess
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
         //   count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
        //wild
    }
}
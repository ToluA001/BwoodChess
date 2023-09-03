using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BwoodChess.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        private string _label;

        public string Label
        {
            get { return _label; }
            set { 
                _label = value; 
                 OnPropertyChanged();
            }
        }

    }
}

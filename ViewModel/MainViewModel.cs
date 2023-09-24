using BwoodChess.View;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BwoodChess.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;
        private string _tlabel;
        public string TLabel
        {
            get { return _tlabel; }
            set {
                _tlabel = value;
                OnPropertyChanged();
            }
        }
        //-------------------------------------------------
        private string _usernametext;
        public string UserNameText
        {
            get { return _usernametext; }
            set
            {
                if(_usernametext != value)
                {
                    _usernametext = value;
                    OnPropertyChanged();
                }
            }
        }
        //-------------------------------------------------
        private string _passwordtext;
        public string PasswordText
        {
            get { return _passwordtext; }
            set
            {
                if(_passwordtext != value)
                {
                    _passwordtext = value;
                    OnPropertyChanged();
                }
            }
        }
        //-------------------------------------------------
        public MainViewModel(INavigation navigation)
        {
            SignUpcommand = new RelayCommand(ShowMessage);
            _navigation = navigation;

        }
        public ICommand SignUpcommand { get; }
        private void ShowMessage()
        {
            TLabel = UserNameText;
            _navigation.PushAsync(new tourneytracker());

        }
    }
}

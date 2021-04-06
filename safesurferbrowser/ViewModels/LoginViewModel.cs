using safesurferbrowser.Views;
using safesurferbrowser.Models;
using safesurferbrowser.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;

namespace safesurferbrowser.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        private IDataStore _datastore;
        public Command CreatePass { get; }
        public AdminSettingsData admin = new AdminSettingsData();
        public string adminPassTemp = "";
         
        public LoginViewModel()
        {            
            LoginCommand = new Command(OnLoginClicked);
            CreatePass = new Command(OnCreatePass); 
            if(adminPassTemp == "")
            {
                LoginVis = false;
                AdminCreateVis = true;
            }

            else
            {
                LoginVis = true;
                AdminCreateVis = false;
            }
        }

        


        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            if (LoginPass == _adminPass)
            {
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
        }

        private async void OnCreatePass(object obj)
        {
            adminPassTemp = AdminPass;
            LoginVis = true;
            AdminCreateVis = false;
        }

        /*public LoginViewModel(AdminSettingsData admin)
        {
            _password = admin.password;
            _email = admin.email;
            _home = admin.home;            
        }*/

        private bool _adminCreateVis;
        public bool AdminCreateVis
        {
            get { return _adminCreateVis; }
            set
            {
                if(_adminCreateVis != value)
                {
                    _adminCreateVis = value;
                    OnPropertyChanged("AdminCreateVis");
                }
            }
        }

        private bool _loginVis;
        public bool LoginVis
        {
            get { return _loginVis; }
            set 
            { 
                if(_loginVis != value)
                {
                    _loginVis = value;
                    OnPropertyChanged("LoginVis");
                }
            }
        }

        private string _loginPass;
        public string LoginPass
        {
            get { return _loginPass; }
            set 
            { 
            if(_loginPass != value)
                {
                    _loginPass = value;
                    OnPropertyChanged("LoginPass");
                }
            }
        }

        private string _adminPass;
        public string AdminPass
        {
            get { return _adminPass; }
            set
            {
                if(_adminPass != value)
                {
                    _adminPass = value;
                    OnPropertyChanged("NewAdminPass");
                }
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if(_password != value)
                {
                    _password = value;                    
                }                
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                }
            }
        }

        private string _home;
        public string Home
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                }
            }
        }
    }
}

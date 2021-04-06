using safesurferbrowser.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace safesurferbrowser.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {

        }

        private string url;
        public string Url
        {
            get { return url; }
            set
            {
                if (url != UrlEntry)
                {
                    url = UrlEntry;
                    OnPropertyChanged("MainWebView");
                }
            }
        }

        private string urlEntry;
        public string UrlEntry
        {
            get { return urlEntry; }
            set
            {
                if (urlEntry != value)
                {
                    urlEntry = value;
                    OnPropertyChanged("UrlEntryBox");
                }
            }
        }
    }
}

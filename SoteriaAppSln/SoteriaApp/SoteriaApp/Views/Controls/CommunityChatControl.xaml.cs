using System;
using Xamarin.Forms;

namespace SoteriaApp.Views.Controls
{
    public partial class CommunityChatControl : ContentView
    {
        public CommunityChatControl()
        {
            InitializeComponent();
            ShowProgress(false);
        }

        private void EntryURL_Completed(object sender, EventArgs e)
        {
            //ShowProgress(true);
            LoadWebPage();
        }

        private void MyWebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            ShowProgress(true);
            entryURL.Text = e.Url.ToString();
        }

        private void BtnLoad_Clicked(object sender, EventArgs e)
        {
            LoadWebPage();
        }

        public void LoadWebPage()
        {
            ShowProgress(true);
            if (entryURL.Text != null && !entryURL.Text.ToString().Trim().Equals(""))
                myWebView.Source = new UriBuilder(entryURL.Text.ToString()).Uri;
        }

        private void MyWebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            entryURL.Text = e.Url.ToString();
            ShowProgress(false);
        }

        public void ShowProgress(Boolean show)
        {
            activityIndicator.IsVisible = show;
            activityIndicator.IsRunning = show;
            btnLoad.IsVisible = !show;
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            ShowProgress(true);
            if (myWebView.CanGoBack)
                myWebView.GoBack();
            else
            {
                entryURL.Text = "https://www.mentalhealthforum.net/forum/";
                LoadWebPage();

            }

        }
    }
}
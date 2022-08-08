using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace SoteriaApp.Views
{
    public partial class ReportPage : ContentPage
    {
        public ReportPage()
        {
            InitializeComponent();
            Reset();
        }

        void Reset()
        {
            ChangeTextColor(5, Color.Gray);
        }

        void ChangeTextColor(int starcount, Color color)
        {
            for (int i = 1; i <= starcount; i++)
            {
                (FindByName($"star{i}") as Label).TextColor = color;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Reset();
            Label clicked = sender as Label;
            ChangeTextColor(Convert.ToInt32(clicked.StyleId.Substring(4, 1)), Color.Orange);
        }

    }
}

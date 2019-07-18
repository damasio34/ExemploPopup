
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExemploPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupView : Rg.Plugins.Popup.Pages.PopupPage
	{
		public PopupView()
		{
			InitializeComponent();
        }

        private async void ChangeOnClick(object sender, int score)
        {
            var button = (Button)sender;

            button.BackgroundColor = Color.FromHex("#40c18f");
            button.TextColor = Color.White;

            await PopupNavigation.Instance.PopAllAsync();
            await PopupNavigation.PushAsync(new PopupComentarioView(score));
        }

        private void Button1_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 1);
        private void Button2_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 2);
        private void Button3_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 3);
        private void Button4_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 4);
        private void Button5_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 5);
        private void Button6_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 6);
        private void Button7_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 7);
        private void Button8_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 8);
        private void Button9_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 9);
        private void Button10_Clicked(object sender, EventArgs e) => ChangeOnClick(sender, 10);

        private void btnClose_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync();
        }
    }
}
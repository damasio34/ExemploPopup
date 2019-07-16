
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

        private void ChangeOnClick(object sender)
        {
            var button = (Button)sender;

            button.BackgroundColor = Color.Green;
            button.TextColor = Color.White;
        }

        private void Button1_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button2_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button3_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button4_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button5_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button6_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button7_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button8_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button9_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);
        private void Button10_Clicked(object sender, EventArgs e) => ChangeOnClick(sender);

        private void btnClose_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}
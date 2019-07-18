
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExemploPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupFeedbackView : Rg.Plugins.Popup.Pages.PopupPage
	{
		public PopupFeedbackView()
		{
			InitializeComponent();
        }

        private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync();
        }
    }
}
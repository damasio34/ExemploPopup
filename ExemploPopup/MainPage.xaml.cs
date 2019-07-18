using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;

namespace ExemploPopup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void AbrirPopUpCadastro(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new PopupView());
        }
        public async void AbrirPopUpComentario(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new PopupComentarioView());
        }
    }
}

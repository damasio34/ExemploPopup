
using Rg.Plugins.Popup.Services;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExemploPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupComentarioView : Rg.Plugins.Popup.Pages.PopupPage
	{
		public PopupComentarioView(int score) : this()
		{
            PrintButton(score);
        }

        public PopupComentarioView()
        {
            InitializeComponent();
        }

        private void PrintButton(int score)
        {
            switch (score)
            {
                case 1: this.ChangeOnClick(this.button_1); break;
                case 2: this.ChangeOnClick(this.button_2); break;
                case 3: this.ChangeOnClick(this.button_3); break;
                case 4: this.ChangeOnClick(this.button_4); break;
                case 5: this.ChangeOnClick(this.button_5); break;
                case 6: this.ChangeOnClick(this.button_6); break;
                case 7: this.ChangeOnClick(this.button_7); break;
                case 8: this.ChangeOnClick(this.button_8); break;
                case 9: this.ChangeOnClick(this.button_9); break;
                case 10: this.ChangeOnClick(this.button_10); break;
                default: return;
            }

            this.lblNota.Text = $"Por que você escolheu {score}?";
        }

        private void ChangeOnClick(object sender, int score = 0)
        {
            foreach (Button btn in sclButtons.Children.Where(x => x.GetType() == typeof(Button)))
            {
                btn.BackgroundColor = Color.White;
                btn.TextColor = Color.DarkGray;
            }

            var button = (Button)sender;

            button.BackgroundColor = Color.Green;
            button.TextColor = Color.White;
            if (score != 0) this.lblNota.Text = $"Por que você escolheu {score}?";
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
            PopupNavigation.Instance.PopAsync();
        }
    }
}
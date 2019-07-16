using Xamarin.Forms;

namespace ExemploPopup
{
    public class EnhancedButton : Button
    {
        public static BindableProperty PaddingProperty = BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(EnhancedButton), default(Thickness), defaultBindingMode: BindingMode.OneWay);

        public Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }
    }
}

using Microsoft.Maui.Layouts;

namespace MauiApp1;

public partial class Absolute : ContentPage
{
    public Absolute()
    {
        InitializeComponent();

        var absoluteLayout = new AbsoluteLayout();

        var button = new Button
        {
            Text = "Volver a GridLayout",
            Command = new Command(() => Navigation.PushAsync(new Grid()))
        };

        AbsoluteLayout.SetLayoutBounds(button, new Rect(1, 1, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(button, AbsoluteLayoutFlags.PositionProportional);

        absoluteLayout.Children.Add(new StackLayout
        {
            Children =
            {
                new Label { Text = "Aqui Vamos de nuevo...", FontSize = 20 }
            }
        });
        absoluteLayout.Children.Add(button);

        Content = absoluteLayout;
    }
}

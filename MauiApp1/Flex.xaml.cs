using Microsoft.Maui.Layouts;

namespace MauiApp1;

public partial class Flex : ContentPage
{
    public Flex()
    {
        InitializeComponent();

        var flexLayout = new FlexLayout
        {
            Direction = FlexDirection.Column,
            AlignItems = FlexAlignItems.Start
        };

        flexLayout.Children.Add(CreateItem("Enzo Cortez"));
        flexLayout.Children.Add(CreateItem("Enzo Cortez"));
        flexLayout.Children.Add(CreateItem("Enzo Cortez"));

        Content = new ScrollView { Content = flexLayout };
    }

    private View CreateItem(string text)
    {
        var image = new Image { Source = "pulsar.jpg", WidthRequest = 50, HeightRequest = 50 };
        var label = new Label { Text = text, VerticalOptions = LayoutOptions.Center };

        var tapGestureRecognizer = new TapGestureRecognizer
        {
            Command = new Command(() => Navigation.PushAsync(new Absolute()))
        };
        image.GestureRecognizers.Add(tapGestureRecognizer);

        return new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Children = { image, label }
        };
    }
}

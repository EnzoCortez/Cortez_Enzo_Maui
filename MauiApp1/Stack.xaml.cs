namespace MauiApp1;

public partial class Stack : ContentPage
{
    public Stack()
    {
        InitializeComponent();

        var stackLayout = new StackLayout
        {
            VerticalOptions = LayoutOptions.Center,
            Children =
            {
                new Label { Text = "Nombre 1", FontSize = 24 },
                new Label { Text = "Nombre 2", FontSize = 18 },
                new Label { Text = "Nombre 3", FontSize = 14 },
                new Button
                {
                    Text = "Ir a FlexLayout",
                    Command = new Command(() => Navigation.PushAsync(new Flex()))
                }
            }
        };

        Content = stackLayout;
    }
}

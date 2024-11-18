namespace MauiApp1;

public partial class Grid : ContentPage
{
    public Grid()
    {
        InitializeComponent();

        var gridLayout = new Microsoft.Maui.Controls.Grid
        {
            RowDefinitions =
            {
                new RowDefinition { Height = GridLength.Star },
                new RowDefinition { Height = GridLength.Star }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        var redBox = new BoxView { Color = Colors.Red };
        Microsoft.Maui.Controls.Grid.SetRow(redBox, 0);
        Microsoft.Maui.Controls.Grid.SetColumn(redBox, 0);

        var blueBox = new BoxView { Color = Colors.Blue };
        Microsoft.Maui.Controls.Grid.SetRow(blueBox, 0);
        Microsoft.Maui.Controls.Grid.SetColumn(blueBox, 1);

        var greenBox = new BoxView { Color = Colors.Green };
        Microsoft.Maui.Controls.Grid.SetRow(greenBox, 1);
        Microsoft.Maui.Controls.Grid.SetColumn(greenBox, 0);

        var button = new Button
        {
            Text = "Ir a StackLayout",
            Command = new Command(() => Navigation.PushAsync(new Stack()))
        };
        Microsoft.Maui.Controls.Grid.SetRow(button, 1);
        Microsoft.Maui.Controls.Grid.SetColumn(button, 1);

        gridLayout.Children.Add(redBox);
        gridLayout.Children.Add(blueBox);
        gridLayout.Children.Add(greenBox);
        gridLayout.Children.Add(button);

        Content = gridLayout;
    }
}

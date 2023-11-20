namespace iOSIsVisibleBug;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        _isVisible = false;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private bool _isVisible;

    private void Button_OnClicked(object sender, EventArgs e)
    {
        _isVisible = !_isVisible;
        BottomGrid.InputTransparent = !_isVisible;
        BottomGrid.IsVisible = _isVisible;
    }

    private void Button_OnClicked2(object sender, EventArgs e)
    {
        _isVisible = !_isVisible;
        BottomGrid.InputTransparent = !_isVisible;
        BottomGrid.IsVisible = _isVisible;
    }
}
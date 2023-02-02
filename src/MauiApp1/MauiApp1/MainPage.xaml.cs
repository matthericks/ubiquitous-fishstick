namespace MauiApp1;

public partial class MainPage {
    public static readonly BindableProperty Visible1Property = BindableProperty.Create(nameof(Visible1), typeof(bool), typeof(MainPage));
    public static readonly BindableProperty Visible2Property = BindableProperty.Create(nameof(Visible2), typeof(bool), typeof(MainPage));

    public bool Visible1 { get => (bool)GetValue(Visible1Property); set => SetValue(Visible1Property, value); }
    public bool Visible2 { get => (bool)GetValue(Visible2Property); set => SetValue(Visible2Property, value); }

    public List<int> Items1 { get; } = new() { 1, 2, 3 };
    public List<int> Items2 { get; } = new() { 4, 5, 6 };
    
    public MainPage() => InitializeComponent();

    private void Button1Clicked(object sender, EventArgs e) => Visible1 = !Visible1;

    private void Button2Clicked(object sender, EventArgs e) => Visible2 = !Visible2;
}

namespace SchoolApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnOpenStudentsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StudentsPage));
    }
}
namespace SchoolApp;

using SchoolApp.ViewModels;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new Person();
    }

    private async void OnOpenStudentsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StudentsPage));
    }
}
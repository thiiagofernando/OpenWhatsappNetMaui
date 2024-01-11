namespace OpenWhatsapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        async void OpenWhatsapp(object sender, EventArgs e)
        {
            await Browser.OpenAsync($"https://wa.me/55{numeroTelefone.Text}");
        }
    }

}

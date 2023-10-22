using Android.App;
namespace Lab8PatientInfo;
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
    {
            InitializeComponent();
            this.cbxBMI.Items.Add("Underweight");
            this.cbxBMI.Items.Add("Normal");
            this.cbxBMI.Items.Add("Overweight");
    }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var reponse = await DisplayAlert("Confirmation", "Do you want to submit?", "OK", "Cancel");
            if (reponse)
            {
                await DisplayAlert("Information", "Information submitted", "OK");
            }  
            SemanticScreenReader.Announce(btnSubmit.Text);
        }   
    }




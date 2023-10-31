using System.Collections.ObjectModel;

namespace Lab8PatientInfo;
public partial class MainPage : ContentPage
    {
        int count = 0;
        App thisApp = Microsoft.Maui.Controls.Application.Current as App;

        public MainPage()
    {
            InitializeComponent();
            this.cbxBMI.Items.Add("Underweight");
            this.cbxBMI.Items.Add("Normal");
            this.cbxBMI.Items.Add("Overweight");

            thisApp.PatientList = new ObservableCollection<Patient>();
    }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var reponse = await DisplayAlert("Confirmation", "Do you want to submit?", "OK", "Cancel");
            if (reponse)
            {
                Patient p = new Patient(count++, this.txtName.Text, this.dtpDateofBirth.Date, this.swtGender.IsToggled, 
                                        this.cbxIncome.SelectedItem.ToString(),this.cbxBMI.SelectedItem.ToString());
                thisApp.PatientList.Add(p);
                await DisplayAlert("Information", "Information submitted", "OK");
            }  
            //SemanticScreenReader.Announce(btnSubmit.Text);
        }
        private void btnView_Clicked(object sender, EventArgs e)
        {
        Navigation.PushModalAsync(new PatientList(),true);
        }
    
    }




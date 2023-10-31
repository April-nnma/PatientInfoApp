namespace Lab8PatientInfo;

public partial class PatientList : ContentPage
{
	App thisApp = Microsoft.Maui.Controls.Application.Current as App;
	public PatientList()
	{
		InitializeComponent();
		collectionView.ItemsSource = thisApp.PatientList;
	}
}
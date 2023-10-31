using System.Collections.ObjectModel;
namespace Lab8PatientInfo;

public partial class App : Application
{
	public ObservableCollection<Patient> PatientList;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

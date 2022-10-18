 

namespace BillingDashboardUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.InformationViewModel();
	}
}



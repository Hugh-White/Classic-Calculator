using ClassicCalc.MVVM.ViewModels;
namespace ClassicCalc.MVVM;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();
	}
}
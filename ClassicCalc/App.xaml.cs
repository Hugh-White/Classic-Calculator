using ClassicCalc.MVVM;

namespace ClassicCalc
    
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalcView();
        }
    }
}

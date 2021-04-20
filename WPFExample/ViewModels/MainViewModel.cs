using System.Windows.Input;
using WpfMandelbrotDrawer.Commands;

namespace WPFExample.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private string _MyData = "test";
        public string MyData
        {
            get { return _MyData; }
            set
            {
                _MyData = value;
                OnPropertyChanged(nameof(MyData));
            }
        }

        private ICommand changeToTest;

        public ICommand ChangeToTest
        {
            get
            {
                if (changeToTest == null)
                {
                    changeToTest = new RelayCommand(PerformChangeToTest, CanPerformChangeToTest);
                }

                return changeToTest;
            }
        }

        private bool CanPerformChangeToTest(object obj)
        {
            return MyData != "test";
        }

        private void PerformChangeToTest(object commandParameter)
        {
            MyData = "test";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin001.Interface;


namespace Xamarin001.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /* 
         * ICommand Buttons 
         */
        public ICommand TestCommand { get; private set; }

        private string _Test1;
        public string Test1
        { 
            get => _Test1;
            set => Set(ref _Test1, value);
        }
        /*
         * Command Functions
         */
        public void OnTest()
        {
            Test1 = "Clicked";
            System.Diagnostics.Debug.WriteLine("OnTest()");

            var dialer = DependencyService.Get<IDialer>();
            dialer.dial("010-4941-1336");


        }
        public MainViewModel()
        {
            TestCommand = new Command.RelayCommand(OnTest);

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin001.Interface;
using Xamarin001.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(Caller_UWP))]
namespace Xamarin001.UWP
{
    class Caller_UWP : IDialer
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("UWP" + strPhoneNumber.ToString());
            return true;
        }
    }
}

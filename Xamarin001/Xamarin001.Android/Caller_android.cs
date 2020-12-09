using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin001.Droid;
using Xamarin001.Interface;

// IDialer를 사용시 해당함수를 불러옵니다.
[assembly: Xamarin.Forms.Dependency(typeof(Caller_android))]
namespace Xamarin001.Droid
{
    class Caller_android : IDialer
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("안드로이드" + strPhoneNumber.ToString());
            return true;
        }
    }
}
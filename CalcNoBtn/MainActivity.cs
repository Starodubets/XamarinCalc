using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Net;
using System.Text;

namespace CalcNoBtn
{
    [Activity(Label = "CalcNoBtn", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.button1);
            var label = FindViewById<TextView>(Resource.Id.textView1);
            button.Click += delegate  
            {
                
                
                int fNum = Convert.ToInt32(FindViewById<EditText>(Resource.Id.editText1).Text);
                int sNum = Convert.ToInt32(FindViewById<EditText>(Resource.Id.editText2).Text);
                string strWhatToDo = FindViewById<EditText>(Resource.Id.editText3).Text;
                if (strWhatToDo.Length != 1)
                {
                    label.Text = "Enter correct data";
                    return;
                }
                else
                {
                    char whatToDo = Convert.ToChar(FindViewById<EditText>(Resource.Id.editText3).Text);
                    //label.Text = whatToDo.ToString();
                    label.Text = Functions.Calc(fNum, sNum, whatToDo).ToString();
                }
                
            }; 
        }
    }
}


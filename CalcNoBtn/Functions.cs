using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CalcNoBtn
{
    public class Functions
    {
        public static int Calc(int a, int b, char op)
        {
            int res = 0;
            switch (op)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '/':
                    res = a / b;
                    break;
                case '*':
                    res = a * b;
                    break;
            }
            return res;
        }

        //public static int CalcPHP(int a, int b, char op)
        //{
        //    string Url = "http://localhost/POST/func.php";
        //    string oper = "";
        //    switch (op)
        //    {
        //        case '+':
        //            oper = "plus";
        //            break;
        //        case '-':
        //            oper = "minus";
        //            break;
        //        case '*':
        //            oper = "multiply";
        //            break;
        //        case '/':
        //            oper = "div";
        //            break;

        //        default:
        //            break;
        //    }
        //    string Data = "num1=" + a + "&num2=" + b + "&act=" + oper;
        //    WebRequest req = WebRequest.Create(Url);
        //    req.Method = "POST";
        //    req.Timeout = 100000;
        //    req.ContentType = "application/x-www-form-urlencoded";
        //    byte[] sentData = Encoding.GetEncoding(1251).GetBytes(Data);
        //    req.ContentLength = sentData.Length;
        //    Stream sendStream = req.GetRequestStream();
        //    sendStream.Write(sentData, 0, sentData.Length);
        //    sendStream.Close();
        //    WebResponse res = req.GetResponse();
        //    Stream ReceiveStream = res.GetResponseStream();
        //    StreamReader sr = new StreamReader(ReceiveStream, Encoding.UTF8);
        //    Char[] read = new Char[256];
        //    int count = sr.Read(read, 0, 256);
        //    string Out = String.Empty;
        //    while (count > 0)
        //    {
        //        String str = new String(read, 0, count);
        //        Out += str;
        //        count = sr.Read(read, 0, 256);
        //    }
        //    return Convert.ToInt32(Out);
        //}
    }
}
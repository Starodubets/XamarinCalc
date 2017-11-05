using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace UnitTestApp1
{
    [TestFixture]
    public class TestsSample
    {
        private string path = @"C:\Users\Ren\Desktop\CalcNoBtn\CalcNoBtn\bin\Debug\CalcNoBtn.CalcNoBtn.apk";
        private AndroidApp app;
        [SetUp]
        public void Setup()
        {
            app = ConfigureApp.Android.ApkFile(path).StartApp();
        }


        [TearDown]
        public void Tear() { }

        [Test]
        public void Pass()
        {
            app.Repl();
        }
    }
}
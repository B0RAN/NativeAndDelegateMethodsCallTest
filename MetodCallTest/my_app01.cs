using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace MetodCallTest
{
    public delegate string fn_dummy();


    public class my_app01
    {
        private MethodInfo method;
        public string title = "Info";

        public my_app01()
        {
            method = this.GetType().GetMethod("dummy", BindingFlags.Public | BindingFlags.Instance);
        }

        public string dummy()
        {
            return "dummy01";
        }

        public string run()
        {
            return (string)method.Invoke(this, null);
        }
    }

    public class my_app02
    {
        private fn_dummy method;
        public string title = "Delegate";

        public my_app02()
        {
            MethodInfo method_info = this.GetType().GetMethod("dummy", BindingFlags.Public | BindingFlags.Instance);
            method = (fn_dummy)Delegate.CreateDelegate(typeof(fn_dummy), this, method_info, true);
        }

        public string dummy()
        {
            return "dummy02";
        }

        public string run()
        {
            return method();
        }
    }

    public static class dt
    {
        private static my_app01 app01 = new my_app01();
        private static my_app02 app02 = new my_app02();

        public static string run()
        {
            string result = string.Empty;
            Int64 n = 0;
            Int64 total = 10000000;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (n = 0; n < total; n++)
            {
                app01.run();
            }
            sw.Stop();
            result = " " + String.Format("{0} {1}ms", app01.title, sw.ElapsedMilliseconds.ToString());

            sw.Restart();
            for (n = 0; n < total; n++)
            {
                app02.run();
            }
            sw.Stop();
            result += " " + String.Format("{0} {1}ms", app02.title, sw.ElapsedMilliseconds.ToString());

            sw.Restart();
            for (n = 0; n < total; n++)
            {
                app02.dummy();
            }
            sw.Stop();
            result += " " + String.Format("Native {0}ms", sw.ElapsedMilliseconds.ToString());

            return result;
        }
    }

}

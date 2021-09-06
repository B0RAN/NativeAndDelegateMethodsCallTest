using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace MetodCallTest
{
    class Program
    {
        const int Iterations = 10;
        static void Main(string[] args)
        {
            for (int ia = 0; ia < 100; ia++)
            {

                //my_app01 app = new my_app01();
                //app.run();


                //my_app02 app_2 = new my_app02();
                //app_2.run();

                Console.WriteLine(dt.run());
                

            }

            Console.Read();

        }
    }
}
    //public class action
    //{
    //    private static MethodInfo _method = typeof(application).GetMethod("SomePublicMethod", BindingFlags.NonPublic | BindingFlags.Static);

    //    public string SomePublicMethod()
    //    {
    //        return (string)_method.Invoke(null, null);
    //    }
    //}

    //public class action_2
    //{
    //    public static MethodInfo methode = typeof(application).GetMethod("run", BindingFlags.NonPublic | BindingFlags.Static);

    //    public delegate string delegem();

    //    public delegem delege = (delegem)Delegate.CreateDelegate(typeof(delegem), methode);
      
    //    public string run()
    //    {
    //        return delege();
    //    }

    //}

    //public class application
    //{
    //    public int MyProperty { get; set; }
 
    //}
//}
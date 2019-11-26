using Castle.Windsor;
using System;

namespace Abp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = new WindsorContainer())
            {
                container.Register();




            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonConversion.Objects
{
    public class TestObject1
    {
        public EventHandler MyEvent;

        private string hmmm;

        public string A { get; set; }

        public int B { get; set; }

        public double C { get; set; }

        public string? D { get; set; }

        public TestObject1(string a, int b, double c, string? d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public static void TestMethod()
        {

        }

        public void AnotherMethod(string astd)
        {
            Test();
        }

        private int Test()
        {
            return 0;
        }
    }
}

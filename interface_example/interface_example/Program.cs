using System;

namespace interface_example
{

    interface ISimpleMath
    {
        double Add(double a, double b);
        double Sub(double a, double b);
    }
    interface IAdvanceMath
    { 
        double Multiply(double a, double b);    
        double Divide(double a, double b);
    }
    interface ICompleteMath : IAdvanceMath, ISimpleMath { }

    class MyMath : ISimpleMath, IAdvanceMath, ICompleteMath
    {
        public double Add(double a, double b)
        {
            throw new NotImplementedException();
        }
        public double Sub(double a, double b)
        {
            throw new NotImplementedException();
        }
        public double Divide(double a, double b)
        {
            throw new NotImplementedException();
        }
        public double Multiply(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
    class StupidMath : ICompleteMath
    {
        public double Add(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Divide(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Multiply(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Sub(double a, double b)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ISimpleMath simpleMath = new MyMath();
            IAdvanceMath advanceMath = new MyMath();
            ICompleteMath completeMath = new MyMath();
            ICompleteMath stupidMath = new StupidMath();

            var a = simpleMath.Add(1, 2);
            var b = simpleMath.Sub(2, 1); // bara Add och Sub finns tillgängliga på detta interface

            var c = advanceMath.Multiply(3, 4);
            var d = advanceMath.Divide(4, 2); // bara Multiply och Divide finns tillgängliga på detta interfacet

            var e = completeMath.Add(1, 2);
            var f = completeMath.Sub(3, 2);
            var g = completeMath.Multiply(4, 2);
            var h = completeMath.Divide(4, 2); // alla metoder finns tillgängliga via detta interface

            var i = stupidMath.Add(1, 2);
            var j = stupidMath.Sub(3, 2);
            var k = stupidMath.Multiply(4, 2);
            var l = stupidMath.Divide(4, 2); // alla metoder finns tillgängliga via detta interface, 
                                             // men implementationen är en annan klass och kan vara av annat innehåll.

            // tänk tanken IGeMigDataHanterare - som interface
            // sen kan du ange en klass för att läsa i från database, en ifrån fil, en tredje från nätverk och så vidare,
            // och all kod som använder IGeMigDataHanterare behöver aldrig ändras eller ens veta om vad datakällan är.



        }
    }
}

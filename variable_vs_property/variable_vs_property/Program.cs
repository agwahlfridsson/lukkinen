using System;

namespace variable_vs_property
{
    public class testclass
    {
        // använd aldrig publika variabler.
        public int A_variable = 0;

        public int A_Property { get; set; }
        public int B_Property { get; private set; }

        private int c_property = 0;
        public int C_property
        {
            get { return c_property; }
            set 
            {
                if (B_Property >= 0)
                {
                    c_property = value; 
                }
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var obj = new testclass();
            // ingen skillnad på variable och property i fallet med A
            obj.A_variable = 2;
            obj.A_Property = 3;

            // B_property får bara klassen sätta internt = kan inte påverkas utifrån direkt.
            obj.B_Property = 4;

            // villkorad set = kan styra när eller om ett värde får sättas.
            obj.C_property = 5;

        }
    }
}

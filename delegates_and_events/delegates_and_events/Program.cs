using System;

namespace delegates_and_events
{
    delegate void IntHandler(int value);

    class testclass
    {
        internal event IntHandler ValueUpdated;
        internal void TriggerEvent()
        { 
            if(this.ValueUpdated != null)
                this.ValueUpdated(14);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var obj = new testclass();
            obj.ValueUpdated += Obj_ValueUpdated; //lyssna på eventet
            obj.TriggerEvent();                   // kör en metod som triggar eventet
            obj.ValueUpdated -= Obj_ValueUpdated; //sluta lyssna på eventet

            
        }

        private static void Obj_ValueUpdated(int value)
        {
            // hantera att objektet signalerar att dess värde har ändrats
        }
    }
}

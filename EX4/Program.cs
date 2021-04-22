using System;
using System.Collections.Generic;

namespace Test_cours
{
    /// <summary>
    /// demo class.
    /// </summary>
    public class Program4
    {
        public abstract class Temp
        {
            public abstract double get_Actual_Temp();

            public abstract double[] get_Last_Days_Temps();

            public abstract bool set_Heater(bool Mode);

            public bool Mode = false;
        }
    }
}
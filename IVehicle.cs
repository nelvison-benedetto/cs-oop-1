using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace cs_oop_1
{
    internal interface IVehicle
    {
        public abstract void start();
        public abstract string getGPSPosition();

        int myProperty { get; }  //property readonly (non c'è 'set;')
        public void stop() {   //'default', ma se scrivi esplicitamente 'default' da error, cmnq ok 
            Console.WriteLine("Vehicle stopping...");
        }
        public static void printInfoInterface()   //static
        {
            Console.WriteLine("This is Vehicle interface.");  //call with IVehicle.printInfoInterface();
        }
    }
}

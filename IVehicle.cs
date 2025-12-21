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
        public void stop() {   //'default', ma se scrivi esplicitamente 'default' da error, cmnq ok , ovveride opzionale
            Console.WriteLine("Vehicle stopping...");
        }
        public static void printInfoInterface()   //static, chiamalo direttamente w IVehicle.printInfoInterface();
        {
            Console.WriteLine("This is Vehicle interface.");
        }
        private void myPrivateMethod(string mex)  //private
        {
            Console.WriteLine(mex);
        }
        event Action OnStart;  //event

    }
}

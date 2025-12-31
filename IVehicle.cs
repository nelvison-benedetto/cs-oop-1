using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace cs_oop_1
{
    internal interface IVehicle
    {
        public abstract void Start();
        string GetGpsPosition();  //è implicitamente gia 'public abstract'

        int VehicleId { get; }  //property readonly (non c'è 'set;')
        event Action OnStart;  //event
        public void Stop()
        {   //'default', se scrivi esplicitamente 'default' da error, un default method deve avere (public, body, no abstract, no static)🔥, ovveride opzionale
            Console.WriteLine("Vehicle stopping...");
        }
        public static void printInfoInterface()   //static, chiamalo direttamente w IVehicle.printInfoInterface();
        {
            Console.WriteLine("This is Vehicle interface.");
        }
        private void myPrivateMethod(string mex)  //private, magari utile come helper interno dell'interface xk non lo vedra nessun'altro
        {
            Console.WriteLine(mex);
        }
        

    }
}

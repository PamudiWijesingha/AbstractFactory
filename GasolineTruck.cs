using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GasolineTruck : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is a gasoline truck with a gasoline engine.");
        }
    }
}

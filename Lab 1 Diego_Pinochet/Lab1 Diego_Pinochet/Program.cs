using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Diego_Pinochet
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona person = new Persona();
            person.Name = "Bob";
            person.LastName = "Kunga";

            person.Lanzar();
        }
    }
}

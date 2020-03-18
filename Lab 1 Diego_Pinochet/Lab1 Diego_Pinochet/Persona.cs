using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Diego_Pinochet
{
    class Persona
    {
        private string Name;
        private string LastName;

        public Persona(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public void Lanzar()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(0, 3));
        }
    }
}

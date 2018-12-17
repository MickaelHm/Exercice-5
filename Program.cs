using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Ecrivez votre nom suivi de votre prénom puis appuyez sur entrée");
            name = Console.ReadLine();
            Console.WriteLine("Bonjour " + name + ", nous somme le " + DateTime.Now.ToLongDateString() + ", comment allez-vous?") ;


           
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Mohamoud Mohamed
/// 300435435
/// Lab-3
/// v.02
/// </summary>
namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck thedeck = new Deck(); 
            thedeck.Display(); 

            thedeck.Shuffle(); 
            thedeck.Display(); 

            Card cardDealt = thedeck.Deal();
            Console.WriteLine("Card Delt: {0} of {1}", cardDealt.FaceFromEnum, cardDealt.SuitFromEnum);
            Console.WriteLine();
            thedeck.Display();

            cardDealt = thedeck.Deal();
            Console.WriteLine("Card Delt: {0} of {1}", cardDealt.FaceFromEnum, cardDealt.SuitFromEnum);
            Console.WriteLine();
            thedeck.Display();
        }
    }
}

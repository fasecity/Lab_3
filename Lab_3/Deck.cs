using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Deck : List<Card>
    {

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * Default constructor
         * </summary>
         * 
         * @constructor Deck
         */
        public Deck()
        {
            // create my deck of cards
            this._create();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method loads the list from card objects from the enum classes
         * </summary>
         * 
         * @private
         * @method _create
         * @returns {void}
         */
        private void _create()
        {

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Faces face in Enum.GetValues(typeof(Faces)))
                {
                    this.Add(new Card(face, suit)); // anonymous Card object to the list
                }
            }

        } // end CreateDeck method


        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method displays a List of Card objects to the Console
         * </summary>
         * 
         * @method Display
         * @returns {void}
         */
        public void Display()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+                    Current Deck             +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this)
            {
                Console.WriteLine("{0} of {1}", card.FaceFromEnum, card.SuitFromEnum);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

        /**
         * <summary>
         * This method randomly shuffles a List of Card objects
         * </summary>
         * 
         * @method Shuffle
         * @returns {void}
         */
        public void Shuffle()
        {
            // creates a pseudo-random number sequence and stores it in random
            Random random = new Random();
            // record the number of cards in the deck List
            int cardCount = this.Count;

            // iterate through the list using Fisher yates algorithm
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card temporaryOutlet= this[currentCard]; 
                int randomCard = random.Next(0, cardCount);
                this[currentCard] = this[randomCard]; 
                this[randomCard] = temporaryOutlet; 
            }

        }

        /**
         * <summary>
         * This method will remove the 0th item from the deck and return it to the caller
         * </summary>
         * 
         * @method Deal
         * @returns {Card}
         */
        public Card Deal()
        {
            Card CardAtTheTop = this[0]; // copy the 0th card (top card) in the stack to the returnedCard

            // check to see if the deck is not empty
            if (this.Count > 0)
            {
                this.RemoveAt(0); // remove the 0th Card (top card) from deck
            }

            return CardAtTheTop;
        }
    }
}


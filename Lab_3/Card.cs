using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
  public  class Card
    {
        // ++++++++++++++++++++++++++++++++PUBLIC PROPERTIES ++++++++++++++++++++++++++++
        
       //These are the enums that come from the Faces and Suits enum Class.
        public Faces FaceFromEnum { get; set; }
        public Suits SuitFromEnum { get; set; }

        /**
         * <summary>
         * This constructor takes two paramaters: face and suit to make the card objet
         * </summary>
         * 
         * @constructor Card
         * @ param {Faces} faceParamFromCtor
         * @ param {Suits} suitParamFromCtor
         */
        public Card(Faces faceParamFromCtor, Suits suitParamFromctor)
        {
            this.FaceFromEnum = faceParamFromCtor;
            this.SuitFromEnum = suitParamFromctor;
        }
    }
}

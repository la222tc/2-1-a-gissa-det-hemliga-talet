using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        private int _count;
        private int _number;
        private int guesses = 7;
        public const int MaxNumberOfGuesses = 7;

        public void Initialize()
        {
            Random rnd = new Random();
            _number = rnd.Next(1, 100);
            _count = 0;
        }

        public bool MakeGuess(int number)
        {
            if (_count == 0)
            {
                guesses = 7;
            }

            guesses--;

            if (_count == 7)
            {
                throw new ApplicationException();
            }

            _count++;

            if (_count == 7 && number < _number)
            {
                Console.WriteLine("{0} är för lågt. Du har 0 gissningar kvar.\nDet hemliga talet är {1}.", number, _number);
                return false;
            }

            if (_count == 7 && number > _number)
            {
                Console.WriteLine("{0} är för högt. Du har 0 gissningar kvar.\nDet hemliga talet är {1}.", number, _number);
                return false;
            }

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number < _number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, guesses);
                return false;
            }

            if (number > _number)
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, guesses);
                return false;
            }


            if (number == _number)
            {
                Console.WriteLine("RÄTT GISSAT. Du klarade det på {0} försök", _count);
                return true;
            }

            return true;
        }

        public SecretNumber()
        {
            Initialize();
        }
    }
}

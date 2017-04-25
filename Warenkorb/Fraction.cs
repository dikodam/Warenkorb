using System;
using System.Runtime.Remoting.Messaging;

namespace Warenkorb
{
    public class Fraction : IComparable
    {
        /// Zähler
        private int Numerator { get; set; }

        /// Nenner
        private int Denominator { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="o">Objekt, mit dem verglichen wird</param>
        /// <returns>
        /// -1 für this < obj <br/>
        /// 0 für this == obj <br/>
        /// 1 für this > obj
        /// </returns>
        public int CompareTo(object o)
        {
            if (!(o is Fraction))
            {
                throw new Exception("wrong type!");
            }

            Fraction compared = (o as Fraction);

            if (this.Numerator == compared.Numerator && this.Denominator == compared.Denominator)
            {
                return 0;
            }
            if (this.Numerator * compared.Denominator < compared.Numerator * this.Denominator)
            {
                return -1;
            }
            // else
            return 1;
        }
    }
}
using System;

namespace Warenkorb
{
    public class Fraction : IComparable
    {
        private double Numerator { get; set; }
        private double Denominator { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="o"></param>
        /// <returns>
        /// -1 für this < obj <br/>
        /// 0 für this == obj <br/>
        /// 1 für this > obj
        /// </returns>
        public int CompareTo(object o)
        {
            if (!(o is Fraction))
            {
                
            }

        }
    }
}
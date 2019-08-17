using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ComplexNumber
    {
        #region Properties
        public double RealPart { get; private set; }
        public double ImaginaryPart { get; private set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{RealPart} + {ImaginaryPart}i";
        }
        #endregion

        #region Constructors
        public ComplexNumber(double realNumber, double imaginaryNumber)
        {
            RealPart = realNumber;
            ImaginaryPart = imaginaryNumber;
        }
        #endregion

        #region Operators
        public static ComplexNumber operator * (ComplexNumber multiplicand, ComplexNumber multiplier)
        {
            double realNumber = (multiplicand.RealPart * multiplier.RealPart)
            -(multiplicand.ImaginaryPart * multiplier.ImaginaryPart);

            double imaginaryNumber = (multiplicand.RealPart * multiplier.ImaginaryPart)
            +(multiplicand.ImaginaryPart * multiplier.RealPart);

            return new ComplexNumber(realNumber, imaginaryNumber);
        }

        public static ComplexNumber operator / (ComplexNumber multiplicand, ComplexNumber multiplier)
        {
            double denominator = (multiplier.RealPart * multiplier.RealPart) 
            + (multiplier.ImaginaryPart * multiplier.ImaginaryPart);

            double realNumber = (multiplicand.RealPart * multiplier.RealPart
            + multiplicand.ImaginaryPart * multiplier.ImaginaryPart)
            / denominator;

            double imaginaryNumber = (multiplicand.ImaginaryPart * multiplier.RealPart
            - multiplicand.RealPart * multiplier.ImaginaryPart)
            / denominator;

            return new ComplexNumber(realNumber, imaginaryNumber);
        }
        #endregion
    }
}

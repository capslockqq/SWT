using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTestUnit
    {
        [Test]
        public void Add_Add3And5_Returns8()
        {
            var uut = new Hand_testing_calculator.Calculator();
            Assert.That(uut.Add(3,5), Is.EqualTo(8));
        }

        [Test]
        public void Subtract_Subtract3And5_ReturnsMinus2()
        {
            var uut = new Hand_testing_calculator.Calculator();
            Assert.That(uut.Subtract(3,5), Is.EqualTo(-2));
        }

        [Test]
        public void Multiply_Multiply3And5_Returns15()
        {
            var uut = new Hand_testing_calculator.Calculator();
            Assert.That(uut.Multiply(3, 5), Is.EqualTo(15));
        }

        [Test]
        public void Power_Power3And5_Returns243()
        {
            var uut = new Hand_testing_calculator.Calculator();
            Assert.That(uut.Power(3, 5), Is.EqualTo(243));
        }
    }
}

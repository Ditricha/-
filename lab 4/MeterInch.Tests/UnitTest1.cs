using System;
using Xunit;

namespace MeterInch.Tests
{
    public class UnitTests
    {
        //tests for meter
        [Fact(DisplayName = "Unary operator + works correctly")]
        public void MeterTest1()
        {
            //arrange
            Meter<Double> meter9 = new Meter<Double>(9.0);
            Meter<Double> expected = new Meter<Double>(10.0);

            //act
            Meter<Double> actual = +meter9;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Unary operator - works correctly")]
        public void MeterTest2()
        {
            //arrange
            Meter<Double> meter8_9 = new Meter<Double>(8.9);
            Meter<Double> expected = new Meter<Double>(7.9);

            //act
            Meter<Double> actual = -meter8_9;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator + works correctly")]
        public void MeterTest3()
        {
            //arrange
            Meter<Double> meter17 = new Meter<Double>(17.0);
            Meter<Double> meter3 = new Meter<Double>(3.0);
            Meter<Double> expected = new Meter<Double>(20.0);

            //act
            Meter<Double> actual = meter17 + meter3;

            //assert
            Assert.Equal(expected, actual);
        }

        //
        [Fact(DisplayName = "Binary operator + works correctly witn meter and inch")]
        public void MeterTest4()
        {
            //arrange
            Meter<Double> meter3 = new Meter<Double>(3.0); //118.11
            Inch<Double> inch394 = new Inch<Double>(394.0); //10.0076
            Meter<Double> expected = new Meter<Double>(13.0076);

            //act
            Meter<Double> actual = meter3 + (Meter<Double>)inch394;

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact(DisplayName = "Binary operator - works correctly")]
        public void MeterTest5()
        {
            //arrange
            Meter<Double> meter17 = new Meter<Double>(17.0);
            Meter<Double> meter3 = new Meter<Double>(3.0);
            Meter<Double> expected = new Meter<Double>(14.0);

            //act
            Meter<Double> actual = meter17 - meter3;

            //assert
            Assert.Equal(expected, actual);
        }

        //
        [Fact(DisplayName = "Binary operator - works correctly witn meter and inch")]
        public void MeterTest6()
        {
            //arrange
            Meter<Double> meter9_7 = new Meter<Double>(9.7); //381.89
            Inch<Double> inch500 = new Inch<Double>(500); //12.7
            Meter<Double> expected = new Meter<Double>(3); //118.11

            //act
            Meter<Double> actual = (Meter<Double>)inch500 - meter9_7;

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact(DisplayName = "Binary operator * works correctly")]
        public void MeterTest7()
        {
            //arrange
            Meter<Double> meter5 = new Meter<Double>(5.0);
            Meter<Double> meter2 = new Meter<Double>(2.0);
            Meter<Double> expected = new Meter<Double>(10.0);

            //act
            Meter<Double> actual = meter5 * meter2;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator / works correctly")]
        public void MeterTest8()
        {
            //arrange
            Meter<Double> meter24 = new Meter<Double>(24);
            Meter<Double> meter6 = new Meter<Double>(6);
            Meter<Double> expected = new Meter<Double>(4);

            //act
            Meter<Double> actual = meter24 / meter6;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator == works correctly")]
        public void MeterTest9()
        {
            //arrange
            Meter<Double> meter99 = new Meter<Double>(99.0);
            Meter<Double> meter99_ = new Meter<Double>(99.0);
            bool expected = true;

            //act
            bool actual = meter99 == meter99_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator >= works correctly")]
        public void MeterTest10()
        {
            //arrange
            Meter<Double> meter99 = new Meter<Double>(99.0);
            Meter<Double> meter99_ = new Meter<Double>(99.0);
            bool expected = true;

            //act
            bool actual = meter99 >= meter99_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator <= works correctly")]
        public void MeterTest11()
        {
            //arrange
            Meter<Double> meter99 = new Meter<Double>(99.0);
            Meter<Double> meter99_ = new Meter<Double>(99.0);
            bool expected = true;

            //act
            bool actual = meter99 <= meter99_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator > works correctly")]
        public void MeterTest12()
        {
            //arrange
            Meter<Double> meter99 = new Meter<Double>(99.0);
            Meter<Double> meter99_ = new Meter<Double>(99.0);
            bool expected = false;

            //act
            bool actual = meter99 > meter99_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator < works correctly")]
        public void MeterTest13()
        {
            //arrange
            Meter<Double> meter99 = new Meter<Double>(99.0);
            Meter<Double> meter99_ = new Meter<Double>(99.0);
            bool expected = false;

            //act
            bool actual = meter99 < meter99_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator > works correctly")]
        public void MeterTest14()
        {
            //arrange
            Meter<Double> meter27 = new Meter<Double>(27.0);
            Meter<Double> meter21 = new Meter<Double>(21.0);
            bool expected = true;

            //act
            bool actual = meter27 > meter21;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator < works correctly")]
        public void MeterTest15()
        {
            //arrange
            Meter<Double> meter21 = new Meter<Double>(21.0);
            Meter<Double> meter27 = new Meter<Double>(27.0);
            bool expected = true;

            //act
            bool actual = meter21 < meter27;

            //assert
            Assert.Equal(expected, actual);
        }


        //tests for inch
        [Fact(DisplayName = "Unary operator + works correctly")]
        public void InchTest1()
        {
            //arrange
            Inch<Double> inch11 = new Inch<Double>(11.0);
            Inch<Double> expected = new Inch<Double>(12.0);

            //act
            Meter<Double> actual = +inch11;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Unary operator - works correctly")]
        public void InchTest2()
        {
            //arrange
            Inch<Double> inch11 = new Inch<Double>(11.0);
            Inch<Double> expected = new Inch<Double>(10.0);

            //act
            Meter<Double> actual = -inch11;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator + works correctly")]
        public void InchTest3()
        {
            //arrange
            Inch<Double> inch87 = new Inch<Double>(87.0);
            Inch<Double> inch13 = new Inch<Double>(13.0);
            Inch<Double> expected = new Inch<Double>(100.0);

            //act
            Meter<Double> actual = inch87 + inch13;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator - works correctly")]
        public void InchTest4()
        {
            //arrange
            Inch<Double> inch100 = new Inch<Double>(100.0);
            Inch<Double> inch13 = new Inch<Double>(13.0);
            Inch<Double> expected = new Inch<Double>(87.0);

            //act
            Meter<Double> actual = inch100 - inch13;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator * works correctly")]
        public void InchTest5()
        {
            //arrange
            Inch<Double> inch6 = new Inch<Double>(6.0);
            Inch<Double> inch9 = new Inch<Double>(9.0);
            Inch<Double> expected = new Inch<Double>(54.0);

            //act
            Meter<Double> actual = inch6 * inch9;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator / works correctly")]
        public void InchTest6()
        {
            //arrange
            Inch<Double> inch48 = new Inch<Double>(48.0);
            Inch<Double> inch6 = new Inch<Double>(6.0);
            Inch<Double> expected = new Inch<Double>(8.0);

            //act
            Meter<Double> actual = inch48 / inch6;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator == works correctly")]
        public void InchTest7()
        {
            //arrange
            Inch<Double> inch2 = new Inch<Double>(8);
            Inch<Double> inch2_ = new Inch<Double>(8);
            bool expected = false;

            //act
            bool actual = inch2 == inch2_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator >= works correctly")]
        public void InchTest8()
        {
            //arrange
            Inch<Double> inch17 = new Inch<Double>(17.0);
            Inch<Double> inch17_ = new Inch<Double>(17.0);
            bool expected = false;

            //act
            bool actual = inch17 >= inch17_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator <= works correctly")]
        public void InchTest9()
        {
            //arrange
            Inch<Double> inch17 = new Inch<Double>(17.0);
            Inch<Double> inch17_ = new Inch<Double>(17.0);
            bool expected = false;

            //act
            bool actual = inch17 <= inch17_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator > works correctly")]
        public void InchTest10()
        {
            //arrange
            Inch<Double> inch17 = new Inch<Double>(17.0);
            Inch<Double> inch17_ = new Inch<Double>(17.0);
            bool expected = false;

            //act
            bool actual = inch17 > inch17_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator < works correctly")]
        public void InchTest11()
        {
            //arrange
            Inch<Double> inch17 = new Inch<Double>(17.0);
            Inch<Double> inch17_ = new Inch<Double>(17.0);
            bool expected = false;

            //act
            bool actual = inch17 < inch17_;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator < works correctly")]
        public void InchTest12()
        {
            //arrange
            Inch<Double> inch15 = new Inch<Double>(15.0);
            Inch<Double> inch17 = new Inch<Double>(17.0);
            bool expected = true;

            //act
            bool actual = inch15 < inch17;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact(DisplayName = "Binary operator > works correctly")]
        public void InchTest13()
        {
            //arrange
            Inch<Double> inch17 = new Inch<Double>(17.0);
            Inch<Double> inch15 = new Inch<Double>(15.0);
            bool expected = true;

            //act
            bool actual = inch17 > inch15;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}


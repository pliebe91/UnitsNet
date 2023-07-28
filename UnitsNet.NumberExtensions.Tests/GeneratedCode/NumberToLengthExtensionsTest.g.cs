//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.NumberExtensions.NumberToLength;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToLengthExtensionsTests
    {
        [Fact]
        public void NumberToAngstromsTest() =>
            Assert.Equal(Length.FromAngstroms(2), 2.Angstroms());

        [Fact]
        public void NumberToAstronomicalUnitsTest() =>
            Assert.Equal(Length.FromAstronomicalUnits(2), 2.AstronomicalUnits());

        [Fact]
        public void NumberToCentimetersTest() =>
            Assert.Equal(Length.FromCentimeters(2), 2.Centimeters());

        [Fact]
        public void NumberToChainsTest() =>
            Assert.Equal(Length.FromChains(2), 2.Chains());

        [Fact]
        public void NumberToDataMilesTest() =>
            Assert.Equal(Length.FromDataMiles(2), 2.DataMiles());

        [Fact]
        public void NumberToDecametersTest() =>
            Assert.Equal(Length.FromDecameters(2), 2.Decameters());

        [Fact]
        public void NumberToDecimetersTest() =>
            Assert.Equal(Length.FromDecimeters(2), 2.Decimeters());

        [Fact]
        public void NumberToDtpPicasTest() =>
            Assert.Equal(Length.FromDtpPicas(2), 2.DtpPicas());

        [Fact]
        public void NumberToDtpPointsTest() =>
            Assert.Equal(Length.FromDtpPoints(2), 2.DtpPoints());

        [Fact]
        public void NumberToFathomsTest() =>
            Assert.Equal(Length.FromFathoms(2), 2.Fathoms());

        [Fact]
        public void NumberToFemtometersTest() =>
            Assert.Equal(Length.FromFemtometers(2), 2.Femtometers());

        [Fact]
        public void NumberToFeetTest() =>
            Assert.Equal(Length.FromFeet(2), 2.Feet());

        [Fact]
        public void NumberToHandsTest() =>
            Assert.Equal(Length.FromHands(2), 2.Hands());

        [Fact]
        public void NumberToHectometersTest() =>
            Assert.Equal(Length.FromHectometers(2), 2.Hectometers());

        [Fact]
        public void NumberToInchesTest() =>
            Assert.Equal(Length.FromInches(2), 2.Inches());

        [Fact]
        public void NumberToKilofeetTest() =>
            Assert.Equal(Length.FromKilofeet(2), 2.Kilofeet());

        [Fact]
        public void NumberToKilolightYearsTest() =>
            Assert.Equal(Length.FromKilolightYears(2), 2.KilolightYears());

        [Fact]
        public void NumberToKilometersTest() =>
            Assert.Equal(Length.FromKilometers(2), 2.Kilometers());

        [Fact]
        public void NumberToKiloparsecsTest() =>
            Assert.Equal(Length.FromKiloparsecs(2), 2.Kiloparsecs());

        [Fact]
        public void NumberToLightYearsTest() =>
            Assert.Equal(Length.FromLightYears(2), 2.LightYears());

        [Fact]
        public void NumberToMegalightYearsTest() =>
            Assert.Equal(Length.FromMegalightYears(2), 2.MegalightYears());

        [Fact]
        public void NumberToMegametersTest() =>
            Assert.Equal(Length.FromMegameters(2), 2.Megameters());

        [Fact]
        public void NumberToMegaparsecsTest() =>
            Assert.Equal(Length.FromMegaparsecs(2), 2.Megaparsecs());

        [Fact]
        public void NumberToMetersTest() =>
            Assert.Equal(Length.FromMeters(2), 2.Meters());

        [Fact]
        public void NumberToMicroinchesTest() =>
            Assert.Equal(Length.FromMicroinches(2), 2.Microinches());

        [Fact]
        public void NumberToMicrometersTest() =>
            Assert.Equal(Length.FromMicrometers(2), 2.Micrometers());

        [Fact]
        public void NumberToMilsTest() =>
            Assert.Equal(Length.FromMils(2), 2.Mils());

        [Fact]
        public void NumberToMilesTest() =>
            Assert.Equal(Length.FromMiles(2), 2.Miles());

        [Fact]
        public void NumberToMillimetersTest() =>
            Assert.Equal(Length.FromMillimeters(2), 2.Millimeters());

        [Fact]
        public void NumberToNanometersTest() =>
            Assert.Equal(Length.FromNanometers(2), 2.Nanometers());

        [Fact]
        public void NumberToNauticalMilesTest() =>
            Assert.Equal(Length.FromNauticalMiles(2), 2.NauticalMiles());

        [Fact]
        public void NumberToParsecsTest() =>
            Assert.Equal(Length.FromParsecs(2), 2.Parsecs());

        [Fact]
        public void NumberToPicometersTest() =>
            Assert.Equal(Length.FromPicometers(2), 2.Picometers());

        [Fact]
        public void NumberToPrinterPicasTest() =>
            Assert.Equal(Length.FromPrinterPicas(2), 2.PrinterPicas());

        [Fact]
        public void NumberToPrinterPointsTest() =>
            Assert.Equal(Length.FromPrinterPoints(2), 2.PrinterPoints());

        [Fact]
        public void NumberToShacklesTest() =>
            Assert.Equal(Length.FromShackles(2), 2.Shackles());

        [Fact]
        public void NumberToSolarRadiusesTest() =>
            Assert.Equal(Length.FromSolarRadiuses(2), 2.SolarRadiuses());

        [Fact]
        public void NumberToTwipsTest() =>
            Assert.Equal(Length.FromTwips(2), 2.Twips());

        [Fact]
        public void NumberToUsSurveyFeetTest() =>
            Assert.Equal(Length.FromUsSurveyFeet(2), 2.UsSurveyFeet());

        [Fact]
        public void NumberToYardsTest() =>
            Assert.Equal(Length.FromYards(2), 2.Yards());

    }
}

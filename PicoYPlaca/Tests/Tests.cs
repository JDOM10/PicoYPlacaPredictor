using PicoYPlaca.Models;
using PicoYPlaca.Services;
using Xunit;
using System;

namespace PicoYPlaca.Tests
{
    public class Tests
    {
        [Fact]
        public void Vehicle_Should_Return_Correct_LastDigit()
        {
            var vehicle = new Vehicle("PBX-1234");
            Assert.Equal(4, vehicle.GetLastDigit());
        }

        [Fact]
        public void CanDrive_Should_Return_False_When_Restricted()
        {
            var vehicle = new Vehicle("PBX-1231"); // Last Digit 1 (restricted on Monday)
            var predictor = new Predictor(vehicle, "2025-02-03", "08:15"); // Monday at a restricted time

            Assert.False(predictor.CanDrive());
        }

        [Fact]
        public void CanDrive_Should_Return_True_When_Not_Restricted()
        {
            var vehicle = new Vehicle("PBX-1231"); // Last Digit 1 (restricted on Monday)
            var predictor = new Predictor(vehicle, "2025-02-03", "10:00"); // Monday but not at a restricted time

            Assert.True(predictor.CanDrive());
        }

        [Fact]
        public void CanDrive_Should_Return_True_When_Not_Affected_Day()
        {
            var vehicle = new Vehicle("PBX-1231"); // Last Digit 1 (restricted on Monday)
            var predictor = new Predictor(vehicle, "2025-02-04", "08:15"); // Tuesday (without restrictions)

            Assert.True(predictor.CanDrive());
        }
    }
}

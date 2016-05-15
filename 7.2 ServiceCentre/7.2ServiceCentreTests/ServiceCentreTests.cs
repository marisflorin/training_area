using _7._2_ServiceCentre;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _7._2_ServiceCentre.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        Vehicle[] listToSort, sortedList;
        [TestMethod()]
        public void SetPriorityStabilityTest()
        {
            listToSort = new Vehicle[]
            {new Vehicle() {owner="John",machineIdNumber= "B000JON",phoneNumber="0755732",priority=Priority.High },
            new Vehicle() {owner="Ion",machineIdNumber= "CJ01ION",phoneNumber="075520000",priority=Priority.Low },
            new Vehicle() {owner="Marcel",machineIdNumber= "CJ08MMM",phoneNumber="032000",priority=Priority.High },
            new Vehicle() {owner="Florin",machineIdNumber= "MS88MVF",phoneNumber="075532",priority=Priority.Medium },
            new Vehicle() {owner="Gigi",machineIdNumber= "GJ00GIG",phoneNumber="55732000",priority=Priority.Low },
            new Vehicle() {owner="Radu",machineIdNumber= "MS00RAD",phoneNumber="07550000",priority=Priority.Medium },
            new Vehicle() {owner="Catalin",machineIdNumber= "MM88CAT",phoneNumber="77770",priority=Priority.High },
            new Vehicle() {owner="BOB",machineIdNumber= "B11BOB",phoneNumber="0900000000",priority=Priority.Low }
            };

            sortedList = new Vehicle[]
            {new Vehicle() {owner="John",machineIdNumber= "B000JON",phoneNumber="0755732",priority=Priority.High },
            new Vehicle() {owner="Marcel",machineIdNumber= "CJ08MMM",phoneNumber="032000",priority=Priority.High },
            new Vehicle() {owner="Catalin",machineIdNumber= "MM88CAT",phoneNumber="77770",priority=Priority.High },
            new Vehicle() {owner="Florin",machineIdNumber= "MS88MVF",phoneNumber="075532",priority=Priority.Medium },
            new Vehicle() {owner="Radu",machineIdNumber= "MS00RAD",phoneNumber="07550000",priority=Priority.Medium },
            new Vehicle() {owner="Ion",machineIdNumber= "CJ01ION",phoneNumber="075520000",priority=Priority.Low },
            new Vehicle() {owner="Gigi",machineIdNumber= "GJ00GIG",phoneNumber="55732000",priority=Priority.Low },
            new Vehicle() {owner="BOB",machineIdNumber= "B11BOB",phoneNumber="0900000000",priority=Priority.Low }
            };
            Service.SetPriority(ref listToSort);
            CollectionAssert.AreEqual(listToSort, sortedList);
        }
        [TestMethod()]
        public void SetPriorityTest()
        {
            listToSort = new Vehicle[]
           {new Vehicle() {owner="John",machineIdNumber= "B000JON",phoneNumber="0755732",priority=Priority.High },
            new Vehicle() {owner="Ion",machineIdNumber= "CJ01ION",phoneNumber="075520000",priority=Priority.Low },
            new Vehicle() {owner="Marcel",machineIdNumber= "CJ08MMM",phoneNumber="032000",priority=Priority.High },
            new Vehicle() {owner="Florin",machineIdNumber= "MS88MVF",phoneNumber="075532",priority=Priority.Medium },
            new Vehicle() {owner="Gigi",machineIdNumber= "GJ00GIG",phoneNumber="55732000",priority=Priority.Low },
            new Vehicle() {owner="Radu",machineIdNumber= "MS00RAD",phoneNumber="07550000",priority=Priority.Medium },
            new Vehicle() {owner="Catalin",machineIdNumber= "MM88CAT",phoneNumber="77770",priority=Priority.High },
            new Vehicle() {owner="BOB",machineIdNumber= "B11BOB",phoneNumber="0900000000",priority=Priority.Low }
            };

            sortedList = new Vehicle[]
           {new Vehicle() {owner="John",machineIdNumber= "B000JON",phoneNumber="0755732",priority=Priority.High },
            new Vehicle() {owner="Catalin",machineIdNumber= "MM88CAT",phoneNumber="77770",priority=Priority.High },
            new Vehicle() {owner="Marcel",machineIdNumber= "CJ08MMM",phoneNumber="032000",priority=Priority.High },
            new Vehicle() {owner="Florin",machineIdNumber= "MS88MVF",phoneNumber="075532",priority=Priority.Medium },
            new Vehicle() {owner="Radu",machineIdNumber= "MS00RAD",phoneNumber="07550000",priority=Priority.Medium },
            new Vehicle() {owner="Gigi",machineIdNumber= "GJ00GIG",phoneNumber="55732000",priority=Priority.Low },
            new Vehicle() {owner="Ion",machineIdNumber= "CJ01ION",phoneNumber="075520000",priority=Priority.Low },
            new Vehicle() {owner="BOB",machineIdNumber= "B11BOB",phoneNumber="0900000000",priority=Priority.Low }
            };
            Service.SetPriority(ref listToSort);
            CollectionAssert.AreEqual(listToSort, sortedList);
        }
    }
}

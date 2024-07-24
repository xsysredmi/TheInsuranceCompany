﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TIC.DomainAPI.Impl;
using TIC.DomainModel;
using TIC.DomainModel.Request;
using TIC.ServiceAdapter;
#pragma warning disable CS8618

namespace TIC.DomainAPI.UnitTests
{
    [TestClass]
    public class InsuranceDomainTests
    {
        private IInsuranceDomain _domain;
        private Mock<IInsuranceProvider> _providerMock;

        [TestInitialize]
        public void Initialize()
        {
            _providerMock = new Mock<IInsuranceProvider>(MockBehavior.Strict);
            _domain = new InsuranceDomain(_providerMock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _providerMock.VerifyAll();
        }

        [TestMethod]
        public void GetInsurances()
        {
            // Arrange
            var request = new GetInsurancesRequest();
            var getInsurancesResponse = new List<Insurance>
            {
                new CarInsurance
                {
                    Name = "Best Car Insurance",
                    Description = "Covers anything and everything",
                    DateOfBirth = new DateTime(1993, 10, 13),
                    InsurancePremium = 50m,
                    LicensePlate = "HF-430-V",
                    WeightInKg = 1100
                }
            };
            
            _providerMock.Setup(x => x.GetInsurances()).Returns(getInsurancesResponse);

            var expectedResponse = new List<Insurance>
            {
                new CarInsurance
                {
                    Name = "Best Car Insurance",
                    Description = "Covers anything and everything",
                    DateOfBirth = new DateTime(1993, 10, 13),
                    InsurancePremium = 50m,
                    LicensePlate = "HF-430-V",
                    WeightInKg = 1100
                }
            };

            // Act
            var actual = _domain.GetInsurances(request);

            // Assert
            actual.Should().BeEquivalentTo(expectedResponse);
        }

        [TestMethod]
        public void GetTravelInsurances()
        {
            // Arrange
            var request = new GetInsurancesRequest();
            var getInsurancesResponse = new List<Insurance>
            {
                new CarInsurance
                {
                    Name = "Best Car Insurance",
                    Description = "Covers anything and everything",
                    DateOfBirth = new DateTime(1993, 10, 13),
                    InsurancePremium = 50m,
                    LicensePlate = "HF-430-V",
                    WeightInKg = 1100
                },
                new TravelInsurance
                {
                    Name = "Best Travel Insurance",
                    Coverage = new List<Country>
                    {
                        new()
                        {
                            Code = "NL",
                            Name = "Netherlands"
                        }
                    },
                    Description = "Insured whilst on the move",
                    InsurancePremium = 20,
                    InsuredAmount = 7000
                }
            };

            _providerMock.Setup(x => x.GetInsurances()).Returns(getInsurancesResponse);

            var expectedResponse = new List<Insurance>
            {
                new TravelInsurance
                {
                    Name = "Best Travel Insurance",
                    Coverage = new List<Country>
                    {
                        new()
                        {
                            Code = "NL",
                            Name = "Netherlands"
                        }
                    },
                    Description = "Insured whilst on the move",
                    InsurancePremium = 20,
                    InsuredAmount = 7000
                }
            };

            // Act
            var actual = _domain.GetDutchTravelInsurances();

            // Assert
            actual.Should().BeEquivalentTo(expectedResponse);
        }
    }
}
using AutoFixture;
using AutoFixture.AutoMoq;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Moq;
using Moq.Protected;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Clockodo.Sdk.UnitTesting.V1
{
    public class GetAbsenceRequestTest
    {
        [Fact]
        public void Year_IsInteger()
        {
    
            var getAbsenceRequest = new Fixture().Create<GetAbsenceRequest>();
            Assert.IsType<int>(getAbsenceRequest.Year);
        }

        [Fact]
        public void UserId_IsInteger()
        {

            var getAbsenceRequest = new Fixture().Create<GetAbsenceRequest>();
            Assert.IsType<int>(getAbsenceRequest.UsersId);
        }

        [Fact]
        public void Year_WithValidInteger() 
        {
            // Arrange
            Fixture fixture = new Fixture();
            int expectedNumber = fixture.Create<int>();
            GetAbsenceRequest sut = fixture.Create<GetAbsenceRequest>();

            // Act
            sut.Year = expectedNumber;

            // Assert
            Assert.Equal(expectedNumber, sut.Year);
        }

        [Fact]
        public void UserId_WithValidInteger()
        {
            // Arrange
            Fixture fixture = new Fixture();
            int expectedNumber = fixture.Create<int>();
            GetAbsenceRequest sut = fixture.Create<GetAbsenceRequest>();

            // Act
            sut.UsersId = expectedNumber;

            // Assert
            Assert.Equal(expectedNumber, sut.UsersId);
        }
    }
}

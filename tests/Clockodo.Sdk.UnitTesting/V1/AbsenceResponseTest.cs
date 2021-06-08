using AutoFixture;
using AutoFixture.AutoMoq;
using Clockodo.Contracts.V1.Absence.Enums;
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
    public class AbsenceResponseTest
    {
        [Fact]
        public void CountDays_IsFloat()
        {
    
            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<float>(absenceResponse.CountDays);
        }

        [Fact]
        public void Id_IsInteger()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<int>(absenceResponse.Id);
        }

        [Fact]
        public void Id_WithValidInteger()
        {
            // Arrange
            Fixture fixture = new Fixture();
            int expected = fixture.Create<int>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.Id = expected;

            // Assert
            Assert.Equal(expected, sut.Id);
        }


        [Fact]
        public void CountHours_IsFloat()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<float>(absenceResponse.CountHours);
        }

        [Fact]
        public void DateSince_IsString()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<string>(absenceResponse.DateSince);
        }

        [Fact]
        public void DateUntil_IsString()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<string>(absenceResponse.DateUntil);
        }


        [Fact]
        public void Note_IsString()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<string>(absenceResponse.Note);
        }

        [Fact]
        public void Type_IsAbsenceTypeEnum()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<AbsenceTypeEnum>(absenceResponse.Type);
        }

        [Fact]
        public void Status_IsAbsenceTypeEnum()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<AbsenceStatusEnum>(absenceResponse.Status);
        }



        [Fact]
        public void UserId_IsInteger()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<int>(absenceResponse.UsersId);
        }

        [Fact]
        public void CountDays_WithValidFloat() 
        {
            // Arrange
            Fixture fixture = new Fixture();
            float expected = fixture.Create<float>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.CountDays = expected;

            // Assert
            Assert.Equal(expected, sut.CountDays);
        }

        [Fact]
        public void CountHours_WithValidFloat()
        {
            // Arrange
            Fixture fixture = new Fixture();
            float expected = fixture.Create<float>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.CountHours = expected;

            // Assert
            Assert.Equal(expected, sut.CountHours);
        }


        [Fact]
        public void DateSince_WithValidString()
        {
            // Arrange
            Fixture fixture = new Fixture();
            string expected = fixture.Create<string>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.DateSince = expected;

            // Assert
            Assert.Equal(expected, sut.DateSince);
        }


        [Fact]
        public void DateUntil_WithValidString()
        {
            // Arrange
            Fixture fixture = new Fixture();
            string expected = fixture.Create<string>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.DateUntil = expected;

            // Assert
            Assert.Equal(expected, sut.DateUntil);
        }

        [Fact]
        public void UsersId_WithValidInt()
        {
            // Arrange
            Fixture fixture = new Fixture();
            int expected = fixture.Create<int>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.UsersId = expected;

            // Assert
            Assert.Equal(expected, sut.UsersId);
        }

        [Fact]
        public void Note_WithValidString()
        {
            // Arrange
            Fixture fixture = new Fixture();
            string expected = fixture.Create<string>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.Note = expected;

            // Assert
            Assert.Equal(expected, sut.Note);
        }

        [Fact]
        public void Type_WithValidAbsenceTypeEnum()
        {
            // Arrange
            Fixture fixture = new Fixture();
            AbsenceTypeEnum expected = fixture.Create<AbsenceTypeEnum>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.Type = expected;

            // Assert
            Assert.Equal(expected, sut.Type);
        }

        [Fact]
        public void Status_WithValidAbsenceStatusEnum()
        {
            // Arrange
            Fixture fixture = new Fixture();
            AbsenceStatusEnum expected = fixture.Create<AbsenceStatusEnum>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.Status = expected;

            // Assert
            Assert.Equal(expected, sut.Status);
        }


        [Fact]
        public void DateEnquired_IsString()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<string>(absenceResponse.DateEnquired);
        }

        [Fact]
        public void DateEnquired_WithValidString()
        {
            // Arrange
            Fixture fixture = new Fixture();
            string expected = fixture.Create<string>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.DateEnquired = expected;

            // Assert
            Assert.Equal(expected, sut.DateEnquired);
        }

        [Fact]
        public void DateApprove_IsString()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<string>(absenceResponse.DateApprove);
        }

        [Fact]
        public void DateApproves_WithString()
        {
            // Arrange
            Fixture fixture = new Fixture();
            string expected = fixture.Create<string>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.DateApprove = expected;

            // Assert
            Assert.Equal(expected, sut.DateApprove);
        }


        [Fact]
        public void ApproveBy_IsInteger()
        {

            var absenceResponse = new Fixture().Create<AbsenceResponse>();
            Assert.IsType<int>(absenceResponse.ApproveBy);
        }

        [Fact]
        public void ApproveBy_WithValidString()
        {
            // Arrange
            Fixture fixture = new Fixture();
            int expected = fixture.Create<int>();
            AbsenceResponse sut = fixture.Create<AbsenceResponse>();

            // Act
            sut.ApproveBy = expected;

            // Assert
            Assert.Equal(expected, sut.ApproveBy);
        }
    }
}

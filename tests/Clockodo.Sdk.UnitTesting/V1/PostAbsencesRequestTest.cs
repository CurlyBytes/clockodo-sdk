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
    public class PostAbsencesRequestTest
    {
        [Fact]
        public void CountDays_IsFloat()
        {
    
            var postAbsencesRequest = new Fixture().Create<PostAbsencesRequest>();
            Assert.IsType<float>(postAbsencesRequest.CountDays);
        }

        [Fact]
        public void CountHours_IsFloat()
        {

            var postAbsencesRequest = new Fixture().Create<PostAbsencesRequest>();
            Assert.IsType<float>(postAbsencesRequest.CountHours);
        }

        [Fact]
        public void DateSince_IsString()
        {

            var postAbsencesRequest = new Fixture().Create<PostAbsencesRequest>();
            Assert.IsType<string>(postAbsencesRequest.DateSince);
        }

        [Fact]
        public void DateUntil_IsString()
        {

            var postAbsencesRequest = new Fixture().Create<PostAbsencesRequest>();
            Assert.IsType<string>(postAbsencesRequest.DateUntil);
        }


        [Fact]
        public void Note_IsString()
        {

            var postAbsencesRequest = new Fixture().Create<PostAbsencesRequest>();
            Assert.IsType<string>(postAbsencesRequest.Note);
        }

        [Fact]
        public void Type_IsInteger()
        {

            var postAbsencesRequest = new Fixture().Create<PostAbsencesRequest>();
            Assert.IsType<int>(postAbsencesRequest.Type);
        }

 

        [Fact]
        public void UserId_IsInteger()
        {

            var postAbsencesRequest = new Fixture().Create<PostAbsencesRequest>();
            Assert.IsType<int>(postAbsencesRequest.UsersId);
        }

        [Fact]
        public void CountDays_WithValidFloat() 
        {
            // Arrange
            Fixture fixture = new Fixture();
            float expected = fixture.Create<float>();
            PostAbsencesRequest sut = fixture.Create<PostAbsencesRequest>();

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
            PostAbsencesRequest sut = fixture.Create<PostAbsencesRequest>();

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
            PostAbsencesRequest sut = fixture.Create<PostAbsencesRequest>();

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
            PostAbsencesRequest sut = fixture.Create<PostAbsencesRequest>();

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
            PostAbsencesRequest sut = fixture.Create<PostAbsencesRequest>();

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
            PostAbsencesRequest sut = fixture.Create<PostAbsencesRequest>();

            // Act
            sut.Note = expected;

            // Assert
            Assert.Equal(expected, sut.Note);
        }

        [Fact]
        public void Type_WithValidInteger()
        {
            // Arrange
            Fixture fixture = new Fixture();
            int expected = fixture.Create<int>();
            PostAbsencesRequest sut = fixture.Create<PostAbsencesRequest>();

            // Act
            sut.Type = expected;

            // Assert
            Assert.Equal(expected, sut.Type);
        }
    }
}

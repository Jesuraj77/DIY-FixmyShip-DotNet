
using FixMyShip.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FixMyShip.Test.TestCases
{
    public class BoundaryTest
    {



        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            User user = new User()
            {
                Password = "111"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
        {

            User user = new User()
            {
                UserName = "111"
            };
            //Arrange
            var MinLength = 0;
            var MaxLength = 50;

            //Action
            var actualLength = user.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }


    }
}

using FixMyShip.BusinessLayer.Services;
using FixMyShip.DataLayer.NHibernateConfigurations;
using FixMyShip.Entities;
using FixMyShip.TestCases.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FixMyShip.TestCases.TestCases
{
    public class ExecptionTest
    {
        private readonly UserService _Userservice;
        private readonly GuestService _Guestservices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExecptionTest()
        {
            _Userservice = new UserService(_session);
            _Guestservices = new GuestService(_session);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFound()
        {
            User user = new User()
            {
                UserName = "aaa",
                Password = "1234"
            };

            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _Userservice.SignIn(user.UserName, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ViewQuestionByUser()
        {
            Question question = new Question()
            {
                QuestionId = 1,

            };

            //Assert
            var ex = Assert.Throws<QuestionNotFoundException>(() => _Userservice.ViewQuestion(question.QuestionId));
            Assert.Equal("Question Not Found ", ex.Messages);
        }


        [Fact]
        public void ExceptionTestFor_ViewAnswerByUser()
        {
            Answer answer = new Answer()
            {
                AnswerId = 1,

            };

            //Assert
            var ex = Assert.Throws<AnswerNotFoundException>(() => _Userservice.ViewAnswer(answer.AnswerId));
            Assert.Equal("Question Not Found ", ex.Messages);
        }


        public void ExceptionTestFor_ViewQuestionByGuest()
        {
            Question question = new Question()
            {
                QuestionId = 1,

            };

            //Assert
            var ex = Assert.Throws<QuestionNotFoundException>(() => _Guestservices.ViewQuestion(question.QuestionId));
            Assert.Equal("Question Not Found ", ex.Messages);
        }


        [Fact]
        public void ExceptionTestFor_ViewAnswerByGuest()
        {
            Answer answer = new Answer()
            {
                AnswerId = 1,

            };

            //Assert
            var ex = Assert.Throws<AnswerNotFoundException>(() => _Guestservices.ViewAnswer(answer.AnswerId));
            Assert.Equal("Question Not Found ", ex.Messages);
        }

    }
}

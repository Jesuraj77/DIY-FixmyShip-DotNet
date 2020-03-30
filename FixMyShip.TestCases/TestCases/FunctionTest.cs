using FixMyShip.BusinessLayer.Services;
using FixMyShip.DataLayer.NHibernateConfigurations;
using FixMyShip.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FixMyShip.TestCases.TestCases
{
    public class FuctionTest
    {
        private readonly UserService _Userservice;
        private readonly GuestService _Guestservice;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();



        public FuctionTest()
        {
            _Userservice = new UserService(_session);

            _Guestservice = new GuestService(_session);

        }


        [Fact]
        public void Test_for_SignUp()
        {
            User user = new User()
            {
                UserId = 1,
                UserName = "aaa",
                Email = "aa@gmail.com",
                Password = "1234"
            };
            var SignUp = _Userservice.SignUp(user);
            Assert.True(SignUp);
        }

        [Fact]
        public void Test_for_SignIn()
        {
            User user = new User()
            {
                UserName = "aaa",
                Password = "1234"
            };
            var SignIn = _Userservice.SignIn(user.UserName, user.Password);
            Assert.True(SignIn);
        }


        [Fact]
        public void Test_for_PostQuestionByUser()
        {
            Question question = new Question()
            {
                QuestionId = 1,
                QuestionDetails = "aaaa"
            };
            var PostQuestion = _Userservice.PostQuestion(question);
            Assert.True(PostQuestion);
        }



        [Fact]
        public void Test_for_PostAnswerByUser()
        {
            Answer answer = new Answer()
            {
                AnswerId = 1,
                AnswerDetails = "aaa"
            };

            Question question = new Question()
            {
                QuestionId = 1,
            };
            var PostAnswer = _Userservice.PostAnswer(answer, question.QuestionId);
            Assert.True(PostAnswer);
        }



        [Fact]
        public void Test_for_DeleteQuestion()
        {
            Question question = new Question()
            {
                QuestionId = 1,
            };
            var DeleteQuestion = _Userservice.DeleteQuestion(question.QuestionId);
            Assert.True(DeleteQuestion);
        }



        [Fact]
        public void Test_for_DeleteAnswer()
        {
            Answer answer = new Answer()
            {
                AnswerId = 1,
            };
            var DeleteAnswer = _Userservice.DeleteAnswer(answer.AnswerId);
            Assert.True(DeleteAnswer);
        }


        [Fact]
        public void Test_for_UpVote()
        {
            Feedback feddback = new Feedback()
            {
                UserId = 1,
                SenderUserId = 1,
            };
            var Resulte = _Userservice.UpVote(feddback.UserId, feddback.SenderUserId);

            Assert.True(Resulte);
        }


        [Fact]
        public void Test_for_PostQuestionByGuest()
        {
            Question question = new Question()
            {
                QuestionId = 1,
                QuestionDetails = "aaaa"
            };
            var PostQuestion = _Guestservice.PostQuestion(question);
            Assert.True(PostQuestion);
        }


        [Fact]
        public void Test_for_PostAnswerByGuest()
        {
            Answer answer = new Answer()
            {
                AnswerId = 1,
                AnswerDetails = "aaa"
            };
            var PostAnswer = _Guestservice.PostAnswer(answer);
            Assert.True(PostAnswer);
        }


        [Fact]
        public void Test_for_AddComment()
        {
            Feedback feedback = new Feedback()
            {
                UserId = 1,
                SenderUserId = 1,
                Comment = "aaaa",
            };
            var PostAnswer = _Userservice.AddComment(feedback);
            Assert.True(PostAnswer);

        }

    }
}

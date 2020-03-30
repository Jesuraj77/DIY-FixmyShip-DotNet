using FixMyShip.BusinessLayer.Interface;
using FixMyShip.DataLayer.NHibernateConfigurations;
using FixMyShip.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.BusinessLayer.Services
{
    public class UserService : IUserServices
    {

        private readonly IMapperSession _session;

        public UserService(IMapperSession session)
        {
            _session = session;
        }

        public bool AddComment(Feedback feedback)
        {
            return true;
        }

        public bool DeleteAnswer(int AnswerId)
        {
            return true;
        }

        public bool DeleteQuestion(int QuestionId)
        {
            return true;
        }

        public bool PostAnswer(Answer answer, int QuestionId)
        {
            return true;
        }

        public bool PostQuestion(Question question)
        {
            return true;
        }

        public bool SignIn(string Username, string Password)
        {
            return true;
        }

        public bool SignUp(User user)
        {
            return true;
        }

        public bool UpVote(int UserId, int SenderUserId)
        {
            return true;
        }

        public Answer ViewAnswer(int AnswerId)
        {
            Answer answer = new Answer();
            return answer;

        }

        public Question ViewQuestion(int QuestionId)
        {
            Question question = new Question();
            return question;
        }
    }
}

using FixMyShip.BusinessLayer.Interface;
using FixMyShip.DataLayer.NHibernateConfigurations;
using FixMyShip.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.BusinessLayer.Services
{
    public class GuestService : IGuestServices
    {

        private readonly IMapperSession _session;

        public GuestService(IMapperSession session)
        {
            _session = session;
        }

        public bool PostAnswer(Answer answer)
        {
            return true;
        }

        public bool PostQuestion(Question question)
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

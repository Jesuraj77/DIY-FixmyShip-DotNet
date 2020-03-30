using FixMyShip.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.BusinessLayer.Interface
{
    public interface IUserServices
    {
        bool SignUp(User user);
        bool SignIn(string Username, string Password);
        bool PostQuestion(Question question);
        bool PostAnswer(Answer answer, int QuestionId);
        bool AddComment(Feedback feedback);
        Question ViewQuestion(int QuestionId);
        Answer ViewAnswer(int AnswerId);
        bool DeleteQuestion(int QuestionId);
        bool DeleteAnswer(int AnswerId);
        bool UpVote(int UserId, int SenderUserId);
    }
}

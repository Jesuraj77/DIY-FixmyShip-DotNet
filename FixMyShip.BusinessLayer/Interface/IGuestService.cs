using FixMyShip.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixMyShip.BusinessLayer.Interface
{
    public interface IGuestServices
    {
        bool PostQuestion(Question question);
        bool PostAnswer(Answer answer);
        Question ViewQuestion(int QuestionId);
        Answer ViewAnswer(int AnswerId);
    }
}

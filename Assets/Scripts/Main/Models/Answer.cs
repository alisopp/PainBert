using System;

namespace Models
{
    public interface Answer
    {
        String GetText();
        AnswerType GetAnswerType();

        int GetEventId();
    }
}
using System;
using UnityEngine;

namespace Models
{
    public class AnswerComponent : MonoBehaviour, Answer
    {
        public int EventId;
        public AnswerType AnswerType;
        public String Text;
        
        public string GetText()
        {
            return Text;
        }

        public AnswerType GetAnswerType()
        {
            return AnswerType;
        }

        public int GetEventId()
        {
            return EventId;
        }
    }
}
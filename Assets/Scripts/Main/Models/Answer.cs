using System;
using UnityEngine;
using UnityEngine.Events;

namespace Models
{
    public class Answer : MonoBehaviour
    {
        public int EventId;
        public AnswerType AnswerType;
        public String Text;
        public Question FollowupQuestion;
        public Question FollowupWrongQuestion;
    }
}
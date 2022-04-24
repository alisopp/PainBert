using System;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    public class Question : MonoBehaviour
    {
        public String Text;
        public List<AnswerComponent> Answers;
        public Question FollowupCorrectAnswer;
        public Question FollowupWrongAnswer;

    }
}
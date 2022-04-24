using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Models
{
    public class Question : MonoBehaviour
    {
        public String Text;
        public List<AnswerComponent> Answers;
        [FormerlySerializedAs("FollowupCorrectAnswer")] public Question FollowupCorrectQuestion;
        [FormerlySerializedAs("FollowupWrongAnswer")] public Question FollowupWrongQuestion;

    }
}
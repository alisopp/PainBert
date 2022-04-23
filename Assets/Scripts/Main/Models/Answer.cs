using System;
using UnityEngine;
using UnityEngine.Events;

namespace Models
{
    public class Answer : MonoBehaviour
    {
        public UnityEvent Events;
        public String Text;
        public Question FollowupQuestion;
    }
}
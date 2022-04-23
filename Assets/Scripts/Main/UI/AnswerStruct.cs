using Models;
using TMPro;
using UnityEngine;

namespace UI
{
    [System.Serializable]
    public struct AnswerStruct
    {
        public GameObject AnswerPanelObject;
        public TextMeshProUGUI Text;
        private Answer _answer;

        public Answer Answer
        {
            get => _answer;
            set => _answer = value;
        }
    }
}
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
        private AnswerComponent _answerComponent;

        public AnswerComponent AnswerComponent
        {
            get => _answerComponent;
            set => _answerComponent = value;
        }
    }
}
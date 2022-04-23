using System;
using Models;
using UI;
using UnityEngine;

namespace Main
{
    public class DialogController : MonoBehaviour
    {

        private static DialogController instance;

        [SerializeField]
        private Answer toolAnswer;

        [SerializeField] 
        private Question startQuestion;

        private Dialog _dialog;
        
        private Question _currentQuestion;

        public static DialogController Instance => instance;

        public Dialog Dialog
        {
            get => _dialog;
            set => _dialog = value;
        }

        private void Awake()
        {
            instance = this;
        }

        public void StartDialog()
        {
            _currentQuestion = startQuestion;
            Dialog.SetQuestion(startQuestion);
        }
        
        public void OnDialogAppear(Answer selectedAnswer)
        {
            _currentQuestion = selectedAnswer.FollowupQuestion;
            Dialog.SetQuestion(selectedAnswer.FollowupQuestion);
        }

        public void OnToolSelected(Tool tool)
        {
            // TODO Add answer to tool and call Dialog.setToolAnswer
        }

        public void OnAnswerCommitted(Answer selectedAnswer)
        {
            
        }
    }
}
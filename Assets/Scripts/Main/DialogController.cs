using System.Diagnostics.Tracing;
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
        public Question startQuestion;

        private Dialog _dialog;
        
        public Question _currentQuestion;

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

        // public void OnToolSelected(Tool tool)
        // {
        //     // TODO Add answer to tool and call Dialog.setToolAnswer
        //
        //     _currentQuestion = tool.FollowupTortureQuestion;
        // }

        public void OnAnswerCommitted(Answer selectedAnswer)
        {
            if (selectedAnswer.AnswerType == AnswerType.CORRECT)
            {
                _currentQuestion = selectedAnswer.FollowupQuestion;
            }

            if (selectedAnswer.AnswerType == AnswerType.WRONG)
            {
                _currentQuestion = selectedAnswer.FollowupWrongQuestion;
            }
            
            Dialog.SetQuestion(_currentQuestion);
        }

        public void SetToolButtonQuestion(Question question)
        {
            _currentQuestion = question;
            Dialog.SetQuestion(_currentQuestion);
        }
    }
}
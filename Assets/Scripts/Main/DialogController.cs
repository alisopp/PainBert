using Models;
using UI;
using UnityEngine;

namespace Main
{
    public class DialogController : MonoBehaviour
    {
        private static DialogController instance;

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
        
        public void OnDialogAppear()
        {

            Dialog.SetQuestion(_currentQuestion);
        }

        // public void OnToolSelected(Tool tool)
        // {
        //     // TODO Add answer to tool and call Dialog.setToolAnswer
        //
        //     _currentQuestion = tool.FollowupTortureQuestion;
        // }

        public void OnAnswerCommitted(Answer selectedAnswerComponent)
        {
            if (selectedAnswerComponent.GetAnswerType() == AnswerType.GAME_OVER)
            {
                // Call game over here;
                UIManager.Instance.SetMenu(UIManager.Menu.GAME_OVER);
                return;
            }else if(selectedAnswerComponent.GetAnswerType() == AnswerType.WIN)
            {
                // Call Win;
                UIManager.Instance.SetMenu(UIManager.Menu.WIN);
                return;
            }

            if (selectedAnswerComponent.GetAnswerType() == AnswerType.CORRECT)
            {
                _currentQuestion = _currentQuestion.FollowupCorrectQuestion;
            }

            if (selectedAnswerComponent.GetAnswerType() == AnswerType.WRONG)
            {
                _currentQuestion = _currentQuestion.FollowupWrongQuestion;
            }
            // Here we call an event
            Dialog.SetQuestion(_currentQuestion);
        }

        public void SetToolButtonQuestion(Question question)
        {
            _currentQuestion = question;
            Dialog.SetQuestion(_currentQuestion);
        }
    }
}
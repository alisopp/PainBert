using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Main;
using Models;
using TMPro;
using UnityEngine;

namespace UI
{
    public class Dialog : MonoBehaviour
    {
        private int index;
        public float textSpeed;
        
        public TextMeshProUGUI QuestionText;
        public AnswerStruct[] answerAreas = new AnswerStruct[2];

        private void Start()
        {
            index = 0;
            SetQuestion(DialogController.Instance.startQuestion);
            
            DialogController.Instance.Dialog = this;
        }

        public void SetQuestion(Question question)
        {
            //StartCoroutine(TypeLine(question.Text.ToCharArray()));
            QuestionText.text = question.Text;
            
            List<AnswerComponent> answers = question.Answers;
            foreach (var answerArea in answerAreas)
            {
                answerArea.AnswerPanelObject.SetActive(false);
            }
            
            for (int i = 0; i < answers.Count; i++)
            {
                answerAreas[i].Text.text = answers[i].Text;
                answerAreas[i].AnswerComponent = answers[i];
                answerAreas[i].AnswerPanelObject.SetActive(true);
            }
        }

        // public void SetToolAnswer(Answer toolAnswer)
        // {
        //     // Third answer is always tool answer
        //     answerAreas[2].Text.text = toolAnswer.Text;
        //     answerAreas[2].Answer = toolAnswer;
        //     answerAreas[2].AnswerPanelObject.SetActive(true);
        // }

        public void AnswerClick(int answerId)
        {
            DialogController.Instance.OnAnswerCommitted(answerAreas[answerId].AnswerComponent);
        }

        private IEnumerator TypeLine(IEnumerable<char> enumChars)
        {
            foreach (char c in enumChars)
            {
                QuestionText.text += c;
                yield return new WaitForSeconds(textSpeed);
            }
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }
    }
}
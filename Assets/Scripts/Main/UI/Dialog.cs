using System;
using System.Collections.Generic;
using Main;
using Models;
using TMPro;
using UnityEngine;

namespace UI
{
    public class Dialog : MonoBehaviour
    {
        public TextMeshProUGUI QuestionText;

        public AnswerStruct[] answerAreas = new AnswerStruct[3];


        private void Start()
        {
            DialogController.Instance.Dialog = this;
        }

        public void SetQuestion(Question question)
        {
            QuestionText.text = question.Text;
            List<Answer> answers = question.Answers;
            foreach (var answerArea in answerAreas)
            {
                answerArea.AnswerPanelObject.SetActive(false);
            }
            
            for (int i = 0; i < answers.Count; i++)
            {
               
                answerAreas[i].Text.text = answers[i].Text;
                answerAreas[i].Answer = answers[i];
                answerAreas[i].AnswerPanelObject.SetActive(true);
            }
        }

        public void SetToolAnswer(Answer toolAnswer)
        {
            // Third answer is always tool answer
            answerAreas[2].Text.text = toolAnswer.Text;
            answerAreas[2].Answer = toolAnswer;
            answerAreas[2].AnswerPanelObject.SetActive(true);
        }

        public void AnswerClick(int answerId)
        {
            DialogController.Instance.OnAnswerCommitted(answerAreas[answerId].Answer);
        }
    }
}
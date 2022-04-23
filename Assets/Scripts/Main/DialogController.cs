using System;
using Models;
using UnityEngine;

namespace Main
{
    public class DialogController : MonoBehaviour
    {

        private static DialogController instance;


        public static DialogController Instance => instance;

        private void Awake()
        {
            instance = this;
        }

        

        public void OnDialogAppear(Answer selectedAnswer)
        {
            // Every time a Answer is selected. Initialize here the followup Question
        }

        public void OnToolSelected(Tool tool)
        {
            
        }

        public void OnAnswerCommitted(Answer selectedAnswer)
        {
            
        }
    }
}
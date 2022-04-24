using System;
using Main;
using Models;
using UI;
using UnityEngine;

public class ToolController : MonoBehaviour
{
    private static int count = 0;
    private static int overallCount = 0;

    public float painMultiplier = 1;
    
    public void SetToolQuestion(Question question)
    {
        count += (int) Math.Round(painMultiplier * 1);
        overallCount += (int) Math.Round(painMultiplier * 1);;

        if(overallCount >= 10)
            UIManager.Instance.SetMenu(UIManager.Menu.GAME_OVER);
        
        if (count >= 5)
        {
            DialogController.Instance.SetToolButtonQuestion(question);
            count = 0;
        }
    }
}

using System;
using Main;
using Models;
using UI;
using UnityEngine;

public class ToolController : MonoBehaviour
{
    private static int _count = 0;
    private static int _overallCount = 0;

    public float painMultiplier = 1;
    
    public void SetToolQuestion(Question question)
    {
        _count += (int) Math.Round(painMultiplier * 1);
        _overallCount += (int) Math.Round(painMultiplier * 1);;

        if (_overallCount >= 10)
        {
            _count = 0;
            _overallCount = 0;
            UIManager.Instance.SetMenu(UIManager.Menu.GAME_OVER);
        }
        
        if (_count >= 5)
        {
            _count = 0;
            DialogController.Instance.SetToolButtonQuestion(question);
        }
    }
}

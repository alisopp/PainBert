using System;
using Main;
using Models;
using UI;
using UnityEngine;

public class ToolController : MonoBehaviour
{
    private static int _count = 0;
    private static int _overallCount = 0;

    public int paintCount = 3;
    public int paintOverallCount = 10;
    public float painMultiplier = 1;
    
    public void SetToolQuestion(Question question)
    {
        _count += (int) Math.Round(painMultiplier * 1);
        _overallCount += (int) Math.Round(painMultiplier * 1);;

        if (_overallCount >= paintOverallCount)
        {
            _count = 0;
            _overallCount = 0;
            UIManager.Instance.SetMenu(UIManager.Menu.GAME_OVER);
        }
        
        if (_count >= paintCount)
        {
            _count = 0;
            DialogController.Instance.SetToolButtonQuestion(question);
        }
    }
}

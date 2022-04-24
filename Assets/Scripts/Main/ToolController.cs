using Main;
using Models;
using UI;
using UnityEngine;

public class ToolController : MonoBehaviour
{
    private static int count = 0;
    private static int overallCount = 0;
    
    public void SetToolQuestion(Question question)
    {
        count++;
        overallCount++;

        if(overallCount >= 5)
            UIManager.Instance.SetMenu(UIManager.Menu.GAME_OVER);
        
        if (count >= 3)
        {
            DialogController.Instance.SetToolButtonQuestion(question);
            count = 0;
        }
    }
}

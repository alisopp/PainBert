using Main;
using Models;
using UnityEngine;

public class ToolController : MonoBehaviour
{
    public void SetToolQuestion(Question question)
    {
        DialogController.Instance.SetToolButtonQuestion(question);
    }
}

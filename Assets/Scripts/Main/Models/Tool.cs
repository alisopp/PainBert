using Main;
using UnityEngine;

namespace Models
{
    public class Tool : MonoBehaviour
    {
        public void OnToolClick(AnswerComponent toolAnswerComponent)
        {
            DialogController.Instance.OnAnswerCommitted(toolAnswerComponent);
        }
    }
}
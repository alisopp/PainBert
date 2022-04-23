using Main;
using UnityEngine;

namespace Models
{
    public class Tool : MonoBehaviour
    {
        public void OnToolClick(Answer toolAnswer)
        {
            DialogController.Instance.OnAnswerCommitted(toolAnswer);
        }
    }
}
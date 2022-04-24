using Main;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TextButton : MonoBehaviour, IPointerClickHandler
{
    // add callbacks in the inspector like for buttons
    public UnityEvent onClick;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //TODO find another way to check for selected answer
        if (pointerEventData.pointerCurrentRaycast.gameObject.name.Equals("Answer1"))
        {
            DialogController.Instance.OnAnswerCommitted(DialogController.Instance.Dialog.answerAreas[0].AnswerComponent);
        }else if (pointerEventData.pointerCurrentRaycast.gameObject.name.Equals("Answer2"))
        {
            DialogController.Instance.OnAnswerCommitted(DialogController.Instance.Dialog.answerAreas[1].AnswerComponent);
        }

        // invoke your event
        onClick.Invoke();
    }
}

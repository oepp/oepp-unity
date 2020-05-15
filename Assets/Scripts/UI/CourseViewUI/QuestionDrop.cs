using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuestionDrop : MonoBehaviour, IDropHandler,IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragged");
    }

    public void OnDrop(PointerEventData eventData)
    {
        int index = eventData.pointerDrag.gameObject.GetComponent<QuestionOption>().index;
        FindObjectOfType<QuestionScreen>().OnOptionsDropped(index);
    }
}

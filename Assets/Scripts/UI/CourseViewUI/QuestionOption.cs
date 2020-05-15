using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuestionOption : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler,IPointerEnterHandler,IDropHandler
{
    public int index;

    public Vector3 firstPosition;

    public void SetOptions(string option,int _index)
    {
        firstPosition = transform.position;
        index = _index;
        GetComponentInChildren<Text>().text = option;
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = firstPosition;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject gameObject = eventData.pointerDrag;
        
        Debug.Log(gameObject.name);
    }
}

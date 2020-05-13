using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuestionOption : MonoBehaviour,IDragHandler
{
    public void SetOptions(string option)
    {
        GetComponentInChildren<Text>().text = option;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Draged");
    }

    public void OptionOnQuestion()
    {

    }
}

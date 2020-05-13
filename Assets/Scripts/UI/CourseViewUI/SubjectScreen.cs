using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubjectScreen : MonoBehaviour
{
    public Text subjectText;

    public void SetSubjectText(string text)
    {
        subjectText.text = text;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class QuestionScreen : MonoBehaviour
{
    public Text questionText;

    public QuestionOption[] options;

    public int rightIndex;

    public void SetQuestionScreen(string questionText,string[] _options,int rightIndex)
    {
        this.questionText.text = questionText;
        this.rightIndex = rightIndex;

        using (var stringOptions = _options.ToList().GetEnumerator())
        using (var quesOptions = options.ToList().GetEnumerator())
        {
            while (stringOptions.MoveNext())
            {
                quesOptions.Current.SetOptions(stringOptions.Current);
            }
        }  
    }
}

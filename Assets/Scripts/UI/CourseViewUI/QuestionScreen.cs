using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class QuestionScreen : MonoBehaviour
{
    public Text questionText;


    public List<QuestionOption> options;

    public int rightIndex;

    public Image questionBlogImage;

    public void SetQuestionScreen(string questionText,string[] _options,int rightIndex)
    {
        this.questionText.text = questionText;
        this.rightIndex = rightIndex;

        for (int i = 0; i < _options.Length; i++)
        {
            options[i].SetOptions(_options[i],i);
        }
    }

    public void OnOptionsDropped(int index)
    {
        StartCoroutine(StartOptionCoroutine(index));
    }

    IEnumerator StartOptionCoroutine(int index)
    {
        if (this.rightIndex == index)
        {
            Color standartColor = questionBlogImage.color;

            questionBlogImage.color = Color.green;

            yield return new WaitForSeconds(2f);

            questionBlogImage.color = standartColor;
            FindObjectOfType<CoursePanel>().ChangeStarPuan(10);
            FindObjectOfType<CoursePanel>().SkipNextSubject();
        }
        else
        {
            Color standartColor = questionBlogImage.color;

            questionBlogImage.color = Color.red;

            FindObjectOfType<CoursePanel>().ChangeStarPuan(-5);

            yield return new WaitForSeconds(2f);

            questionBlogImage.color = standartColor;

        }
    }

}

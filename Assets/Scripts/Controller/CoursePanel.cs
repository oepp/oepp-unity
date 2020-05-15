using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoursePanel : MonoBehaviour
{
    public CourseData currentCourseData;

    int index;

    public SubjectScreen subjectScreen;

    public QuestionScreen questionScreen;

    public GameObject finishScreen;

    public Button nextButton;

    public Text starPuan;

    public Text finishStarPuanText;


    public Button finishButton;

    public void InitiliazeCoursePanel(CourseData courseData)
    {
        starPuan.text = "0";
        index = 0;
        currentCourseData = courseData;
        subjectScreen.gameObject.SetActive(true);
        SetSubjectScreen();
        nextButton.onClick.AddListener(() => SubjectPassed());
    }

    public void SetSubjectScreen()
    {
        subjectScreen.SetSubjectText(currentCourseData.questionSections[index].subject);
        nextButton.interactable = true;
    }

    public void SetQuestionScreen()
    {
        nextButton.interactable = false;
        questionScreen.gameObject.SetActive(true);
        questionScreen.SetQuestionScreen(currentCourseData.questionSections[index].question,
            currentCourseData.questionSections[index].options,
            currentCourseData.questionSections[index].correctOption);
    }

    public void OnQuestionCompleted()
    {
        SkipNextSubject();
    }

    public void SkipNextSubject()
    {
        if (index < currentCourseData.questionSections.Length - 1)
        {
            index++;
            questionScreen.gameObject.SetActive(false);
            subjectScreen.gameObject.SetActive(true);
            SetSubjectScreen();
        }
        else
        {
            FinishCourse();
        }
    }

    public void SubjectPassed()
    {
        subjectScreen.gameObject.SetActive(false);
        SetQuestionScreen();
    }


    public void CloseNextButton()
    {
        nextButton.interactable = false;
    }

    public void FinishCourse()
    {
        subjectScreen.gameObject.SetActive(false);
        questionScreen.gameObject.SetActive(false);
        finishScreen.gameObject.SetActive(true);
        nextButton.gameObject.SetActive(false);

        finishStarPuanText.text = "Score "+starPuan.text;

        finishButton.gameObject.SetActive(true);

        finishButton.onClick.AddListener(()=>ExitFromGame());

    }

    public void ChangeStarPuan(int value)
    {
        int paunValue = int.Parse(starPuan.text);

        paunValue += value;

        starPuan.text = ""+paunValue;
    }

    public void ExitFromGame()
    {
        FindObjectOfType<UserUIController>().OpenUserMainUI();
        finishScreen.gameObject.SetActive(false);
        FindObjectOfType<UserUIController>().CloseCourseView();
    }
}

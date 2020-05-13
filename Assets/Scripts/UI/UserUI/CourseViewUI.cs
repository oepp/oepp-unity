using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CourseViewUI : MonoBehaviour
{
    public Button exitButton;

    public Button nextButton;

    CourseViewController courseController;

    private void Start()
    {
        courseController = FindObjectOfType<CourseViewController>();

        RenderButtons();
    }

    void RenderButtons()
    {
        exitButton.onClick.AddListener(() => OnExitButtonPressed());

        nextButton.onClick.AddListener(() =>OnNextButtonPressed());
    }

    public void OnNextButtonPressed()
    {
        courseController.SkipNext();
    }

    public void OnExitButtonPressed()
    {
        FindObjectOfType<UserUIController>().OpenUserMainUI();
        FindObjectOfType<UserUIController>().CloseCourseView();
    }
}

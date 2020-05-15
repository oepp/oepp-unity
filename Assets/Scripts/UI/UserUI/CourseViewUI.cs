using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CourseViewUI : MonoBehaviour
{
    public Button exitButton;
    
    CourseViewController courseController;

    private void Start()
    {
        courseController = FindObjectOfType<CourseViewController>();

        RenderButtons();
    }

    void RenderButtons()
    {
        exitButton.onClick.AddListener(() => OnExitButtonPressed());
    }

    public void OnExitButtonPressed()
    {
        FindObjectOfType<UserUIController>().OpenUserMainUI();
        FindObjectOfType<UserUIController>().CloseCourseView();
    }
}

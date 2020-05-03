using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserUIController : MonoBehaviour
{
    public UserMainUI userMainUI;

    public UserCoursesUI userCoursesUI;

    public CourseViewUI courseViewUI;

    public void OpenCoursesScreen()
    {
        userCoursesUI.gameObject.SetActive(true);
    }

    public void CloseCoursesScreen()
    {
        userCoursesUI.gameObject.SetActive(false);
    }

    public void OpenUserMainUI()
    {
        userMainUI.gameObject.SetActive(true);
    }

    public void CloseUserMainScreen()
    {
        userMainUI.gameObject.SetActive(false);
    }

    public void OpenCourseView()
    {
        courseViewUI.gameObject.SetActive(true);
    }

    public void CloseCourseView()
    {
        courseViewUI.gameObject.SetActive(false);
    }
}

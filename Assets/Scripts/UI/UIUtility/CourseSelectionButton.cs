using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class CourseSelectionButton : MonoBehaviour,IPointerClickHandler
{
    public Course currentCourse { get; private set; }

    public Action<Course> OnButtonClicked;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnButtonClicked != null)
        {
            OnButtonClicked.Invoke(currentCourse);
        }
    }

    public void SetCourseSelectionButton(Course course)
    {
        this.currentCourse = course;

        AdapteView();
    }

    void AdapteView()
    {
        GetComponentInChildren<Text>().text = currentCourse.courseName;
    }
}

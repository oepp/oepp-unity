using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class CourseSelectionButton : MonoBehaviour,IPointerClickHandler
{
    public CourseData currentCourse { get; private set; }

    public Action<CourseData> OnButtonClicked;

    public void SetCourseSelectionButton(CourseData courseData)
    {
        this.currentCourse = courseData;

        AdapteView();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnButtonClicked != null)
        {
            OnButtonClicked.Invoke(currentCourse);
        }
    }
 
    void AdapteView()
    {
        GetComponentInChildren<Text>().text = currentCourse.courseName;
    }
}

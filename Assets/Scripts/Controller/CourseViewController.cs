using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CourseViewController : MonoBehaviour
{
    public CoursePanel coursePanel;

    public void SetCourseView(CourseData course)
    {
        coursePanel.InitiliazeCoursePanel(course);
    }
}

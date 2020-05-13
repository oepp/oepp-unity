using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CourseViewController : MonoBehaviour
{
    public CourseData courseData;

    public List<QuestionSection> allSections;

    int currentIndex = 0;

    public void SetCourseView(CourseData course)
    {
        this.courseData = course;
        allSections = courseData.questionSections.ToList();
    }

    public void StartToCourse()
    {
        
    }

    public void SkipNext()
    {
        
    }

    public void ViewSubject()
    {

    }

    public void ViewQuestion()
    {

    }
}

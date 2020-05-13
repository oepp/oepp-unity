using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserCoursesUI : MonoBehaviour
{
    public Button backButton;

    public Transform listViewParentTransform;

    public CourseSelectionButton courseSelectionButtonPrefab;

    public void SetCourseListView()
    {
        List<CourseData> allCourses = FindObjectOfType<CourseController>().nonUserCourseDatas;

        Debug.Log("All Courses" +allCourses.Count);

        if (allCourses != null)
        {
            ViewCoursesOnList(allCourses);
        }
        else
        {
            Debug.LogWarning("Courses not found");
        }
    }

    private void ViewCoursesOnList(List<CourseData> courses)
    {
        courses.ForEach(delegate (CourseData course)
        {
            CourseSelectionButton courseSelectionButton = Instantiate(courseSelectionButtonPrefab);

            courseSelectionButton.SetCourseSelectionButton(course);

            courseSelectionButton.OnButtonClicked += OnCourseSelectionButtonClicked;

            courseSelectionButton.transform.SetParent(listViewParentTransform);
        });
    }

    public void OnCourseSelectionButtonClicked(CourseData course)
    {
        FindObjectOfType<CourseViewController>().SetCourseView(course);
    }
}

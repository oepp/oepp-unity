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
        List<Course> allCourses = FindObjectOfType<ResourcesController>().GetAllCourses();

        if (allCourses != null)
        {
            ViewCoursesOnList(allCourses);
        }
        else
        {
            Debug.LogWarning("Courses not found");
        }
    }

    private void ViewCoursesOnList(List<Course> courses)
    {
        courses.ForEach(delegate (Course course)
        {
            CourseSelectionButton courseSelectionButton = Instantiate(courseSelectionButtonPrefab);

            courseSelectionButton.SetCourseSelectionButton(course);

            courseSelectionButton.OnButtonClicked += OnCourseSelectionButtonClicked;

            courseSelectionButton.transform.SetParent(listViewParentTransform);
        });
    }

    public void OnCourseSelectionButtonClicked(Course course)
    {
        FindObjectOfType<CourseViewController>().SetCourseView(course);
    }
}

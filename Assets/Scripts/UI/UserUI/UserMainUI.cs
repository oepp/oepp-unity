using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserMainUI : MonoBehaviour
{
    public Button coursesButton;

    public Button exitAccountButton;

    public Button searchButton;

    public InputField searchedCoursedInputField;

    public Transform listViewParent;

    public CourseSelectionButton courseSelectionButtonPrefab;

    private void Start()
    {
        RenderButtons();
        SetCourseListView();  
    }

    void RenderButtons()
    {
        coursesButton.onClick.AddListener(()=>OnCoursesButtonPressed());

        searchButton.onClick.AddListener(() => OnSearchButtonPressed());

        exitAccountButton.onClick.AddListener(() => OnExitAccountButtonPressed());
    }

    private void OnSearchButtonPressed()
    {

    }

    private void OnCoursesButtonPressed()
    {
        FindObjectOfType<UserUIController>().OpenCoursesScreen();
        FindObjectOfType<UserUIController>().CloseUserMainScreen();
    }

    private void OnExitAccountButtonPressed()
    {
        AppManager.Instance.ExitAccount();
        AppManager.Instance.SetNonUserScene();
    }

    public void SetCourseListView()
    {
        List<CourseData> allCourses = FindObjectOfType<CourseController>().nonUserCourseDatas;

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

            courseSelectionButton.transform.SetParent(listViewParent);
        });
    }

    public void OnCourseSelectionButtonClicked(CourseData course)
    {
        FindObjectOfType<CourseViewController>().SetCourseView(course);
        FindObjectOfType<UserUIController>().OpenCourseView();
        FindObjectOfType<UserUIController>().CloseUserMainScreen();
    }
}

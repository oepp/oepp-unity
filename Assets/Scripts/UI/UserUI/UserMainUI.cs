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

    private void Start()
    {
        RenderButtons();
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
    }
}

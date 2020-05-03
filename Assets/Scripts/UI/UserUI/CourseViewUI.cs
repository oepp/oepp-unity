using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CourseViewUI : MonoBehaviour
{
    public Button exitButton;

    void RenderButtons()
    {
        exitButton.onClick.AddListener(() => OnExitButtonPressed());
    }

    public void OnExitButtonPressed()
    {

    }
}

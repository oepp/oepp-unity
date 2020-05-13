using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResourcesController : MonoBehaviour
{
    public List<CourseData> GetNonUserCourses()
    {
        TextAsset[] textAsset = Resources.LoadAll<TextAsset>("CourseDatas/");

        List<CourseData> allCourses = new List<CourseData>();

        Debug.Log("Txt asset "+textAsset.Length);

        foreach (TextAsset text in textAsset)
        {
            CourseData courseData = JsonUtility.FromJson<CourseData>(text.text);

            allCourses.Add(courseData);
        }

        return allCourses;
    }

    public List<CourseData> GetUserCourses()
    {
        TextAsset[] textAsset = Resources.LoadAll<TextAsset>("UserCourseDatas/");

        List<CourseData> allCourses = new List<CourseData>();

        foreach (TextAsset text in textAsset)
        {
            CourseData courseData = JsonUtility.FromJson<CourseData>(text.text);

            allCourses.Add(courseData);
        }

        return allCourses;
    }
}

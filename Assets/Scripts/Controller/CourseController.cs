using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseController : MonoBehaviour
{
    public List<CourseData> nonUserCourseDatas { get { return FindObjectOfType<ResourcesController>().GetNonUserCourses(); } }
    public List<CourseData> userCourseDatas { get { return FindObjectOfType<ResourcesController>().GetUserCourses(); } }

}

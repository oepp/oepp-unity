using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResourcesController : MonoBehaviour
{
    public List<Course> GetAllCourses()
    {
        return Resources.LoadAll<Course>("").ToList();
    }
}

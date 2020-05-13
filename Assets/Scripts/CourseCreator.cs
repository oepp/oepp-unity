using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseCreator : MonoBehaviour
{
    public QuestionSection[] questionSections =
    {
      new QuestionSection("Atatürk Selenikte dogmuştur","Atatürk selanikte %/ %/ de dogmuştur",new string[]{"Selanik","İstabbul","İzmir"},0),
      new QuestionSection("Atatürk 1881 yılında dogmuştur","Atatürk %/ %& yılında doğmuştur",new string[]{"1900","1881","1978"},1),
      new QuestionSection("Atatürk annesinin adı Zübeyde 'dir","Atatürk annesinin adı %/ %& 'dir",new string[]{"Ayşe","Atiye","Zübeyde"},2),
      new QuestionSection("Atatürk babasının adı Ali Rıza'dir","Atatürk babasının adı %/ %& 'dir",new string[]{"Ali Rıza","Mustafa","Halil"},0),
      new QuestionSection("Atatürk Trablusgarp savaşına katılmıştır","Atatürk %/ %& savaşına katılmıştır",new string[]{"Trablusgarp","Talas","Viyana"},0),
      new QuestionSection("Atatürk TC ilk cumhurbaşkanıdır","Atatürk TC ilk %/ %&",new string[]{"Başbakanı","Genarali","Cumhurbaşkanı",},2),
      new QuestionSection("Atatürk 1938 yılında vefat etmiştir.","Atatürk %/ %& yılında vefat etmiştir.",new string[]{"1938","1945","1948"},0)
    }; 
}

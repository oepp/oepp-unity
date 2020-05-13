using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class QuestionSection
{
    public QuestionSection(string subject,string question,string[] options,int correctOption)
    {
        this.subject = subject;
        this.question = question;
        this.options = options;
        this.correctOption = correctOption;
    }

    public string subject;

    public string question;

    public string[] options;

    public int correctOption;
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions
{
    public string question = "";
    public string[] answers = new string[4];

    public Questions(string q, string a0, string a1, string a2, string a3)
    {
        question = q;
        Console.WriteLine(question + " " + q);
        answers[0] = a0;
        Console.WriteLine(answers[0] + " " + a0);
        answers[1] = a1;
        Console.WriteLine(answers[1] + " " + a1);
        answers[2] = a2;
        Console.WriteLine(answers[2] + " " + a2);
        answers[3] = a3;
        Console.WriteLine(answers[3] + " " + a3);
    }

    public Questions(Questions copy) 
    { 
        this.question = copy.question;
        this.answers[0] = copy.answers[0];
        this.answers[1] = copy.answers[1];
        this.answers[2] = copy.answers[2];
        this.answers[3] = copy.answers[3];
    }
 

    }


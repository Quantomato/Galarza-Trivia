using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question
{
    public string questionLine; // For the actual question itself
    public string correctAnswer; // Correct answer for the question
    public string[] answerList; // List of all answers, though only answerList[0] is correct

    public question(string questionLine, string[] answerList) 
    {
        this.questionLine = questionLine;
        this.correctAnswer = answerList[0];
        this.answerList = answerList;
    }
}

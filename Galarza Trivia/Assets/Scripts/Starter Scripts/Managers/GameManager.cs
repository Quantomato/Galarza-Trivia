using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<listOfQuestions> questionList;
    List<int> askedQuestionIndexList;
    listOfQuestions currentQuestion;
    string currentCorrect;
    string a;
    string b;
    string c;
    string d;
    //This component should be placed on a gameobject in your scene

    [HideInInspector]
    public Vector3 RespawnPlace;

    [Tooltip("Place your player game object in here so this knows where to handle respawns")]
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = FindObjectOfType<PlayerMovement>().gameObject;
        }
        RespawnPlace = Player.transform.position;

        currentQuestion = new listOfQuestions("test", "a", "b", "c", "d");
        questionList = currentQuestion.addQuestions(questionList);
    }

    public void Respawn(GameObject Player)//This is just where we respawn the player
    {
        Player.transform.position = RespawnPlace;
    }
    public void Respawn()
    {
        Player.transform.position = RespawnPlace;
    }

    public void SetNewRespawnPlace(GameObject newPlace)//This is 
    {
        RespawnPlace = newPlace.transform.position;
    }

    public void selectQuestion() 
    {
        int findNumber = 0;
        Boolean check = true;
        while (check)
        {
            findNumber = (int)(UnityEngine.Random.Range(0, questionList.Count));
            for (int i = 0; i < askedQuestionIndexList.Count; i++) 
            {
                if (findNumber == askedQuestionIndexList[i])
                {
                    findNumber = (int)(UnityEngine.Random.Range(0, questionList.Count));
                }
                else
                {
                    check = false;
                }
            }
        }
        askedQuestionIndexList.Add(findNumber);
        currentQuestion = new listOfQuestions(questionList[findNumber]);
        currentCorrect = currentQuestion.answers[0];
        scrambleBoard();
    }

    public void scrambleBoard() 
    {
        System.Random rng = new System.Random();
        int n = currentQuestion.answers.Length;
        while (n > 1) 
        {
            n--;
            int k = rng.Next(n + 1);
            string value = currentQuestion.answers[k];
            currentQuestion.answers[k] = currentQuestion.answers[n];
            currentQuestion.answers[n] = value;
        }
        a = currentQuestion.answers[0];
        b = currentQuestion.answers[1];
        c = currentQuestion.answers[2];
        d = currentQuestion.answers[3];
    }

    public Boolean onTrigger(string returnString) 
    {
        if (returnString == "a")
        {
            if (currentCorrect == a) { return true; }
            else { return false; }
        }
        else if (returnString == "b")
        {
            if (currentCorrect == b) { return true; }
            else { return false; }

        }
        else if (returnString == "c")
        {
            if (currentCorrect == c) { return true; }
            else { return false; }

        }
        else if (returnString == "d")
        {
            if (currentCorrect == d) { return true; }
            else { return false; }

        }
        else 
        {
            Console.WriteLine("Something has gone wrong in onTrigger, or what is being passed into it");
            return false;
        }
    }
}

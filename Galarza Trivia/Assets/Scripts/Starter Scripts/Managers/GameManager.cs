using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    listOfQuestions questionList;
    List<int> askedQuestionIndexList;
    question currentQuestion;
    char currentCharacter;
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
            findNumber = (int)(UnityEngine.Random.Range(0, questionList.questionList.Length));
            for (int i = 0; i < askedQuestionIndexList.Count; i++) 
            {
                if (findNumber == askedQuestionIndexList[i])
                {
                    findNumber = (int)(UnityEngine.Random.Range(0, questionList.questionList.Length));
                }
                else
                {
                    check = false;
                }
            }
        }
        askedQuestionIndexList.Add(findNumber);
        currentQuestion = new question(questionList.questionList[findNumber]);
        scrambleBoard();
    }

    public void scrambleBoard() 
    {
        
    }

    public void setBoard() { }
}

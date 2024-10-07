using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class AnswerTrigger : MonoBehaviour
{
    GameManager gameManager;
    public GameObject answer;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Lmao
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool gotAnswerRight = false;
        //Check to see if the answer is right.
        if (answer.gameObject.name == "Answer_A")
        {
            Debug.Log("Collision with Answer A");
            if (gameManager.currentCorrect == gameManager.a)
            {
                Debug.Log("You chose correct m8");
                gotAnswerRight = true;
            }
            else
            {
                Debug.Log("You chose wrong twerp");
                gotAnswerRight = false;
            }
        }
        else if (answer.gameObject.name == "Answer_B")
        {
            Debug.Log("Collision with Answer B");
            if(gameManager.currentCorrect == gameManager.b){
                Debug.Log("You chose correct m8");
                gotAnswerRight = true;

            } else { 
                Debug.Log("You chose wrong twerp");
                gotAnswerRight = false;
            }
        }
        else if (answer.gameObject.name == "Answer_C")
        {
            if(gameManager.currentCorrect == gameManager.c){
                Debug.Log("You chose correct m8");
                gotAnswerRight = true;

            } else { 
                Debug.Log("You chose wrong twerp");
                gotAnswerRight = false;
            }            
            Debug.Log("Collision with Answer C");
        }
        else if (answer.gameObject.name == "Answer_D")
        {
            if(gameManager.currentCorrect == gameManager.d){
                Debug.Log("You chose correct m8");
                gotAnswerRight = true;

            } else { 
                Debug.Log("You chose wrong twerp");
                gotAnswerRight = false;
            }
            Debug.Log("Collision with Answer D");
        }
        else
        {
            Debug.Log("Stop hacking bruh");
        }

        //If they are right
        if (gotAnswerRight)
        {
            string path = "Assets/Scripts/Starter Scripts/Dialogue/NPC_Interaction_1.txt";
            Debug.Log(path);
            using (var writer = new StreamWriter(path, false))
            {
                Debug.Log("Writing...");
                writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] LET'S GO BABY! The answer was right!");
                writer.Close();
            }
            AssetDatabase.Refresh();
        }
        //If they got it wrong
        else
        {
            string path = "Assets/Scripts/Starter Scripts/Dialogue/NPC_Interaction_1.txt";
            Debug.Log(path);
            using (var writer = new StreamWriter(path, false))
            {
                Debug.Log("Writing...");
                writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] Darn it. The answer was wrong.");
                writer.Close();
            }
            AssetDatabase.Refresh();
        }

    }



}

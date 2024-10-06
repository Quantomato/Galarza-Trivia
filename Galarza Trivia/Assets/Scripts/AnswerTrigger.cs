using System.Collections;
using System.Collections.Generic;
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
        if (answer.gameObject.name == "Answer_A")
        {
            Debug.Log("Collision with Answer A");
            if (gameManager.currentCorrect == gameManager.a)
            {
                Debug.Log("You chose correct m8");

            }
            else
            {
                Debug.Log("You chose wrong twerp");
            }
        }
        else if (answer.gameObject.name == "Answer_B")
        {
            Debug.Log("Collision with Answer B");
            if(gameManager.currentCorrect == gameManager.b){
                Debug.Log("You chose correct m8");

            } else { 
                Debug.Log("You chose wrong twerp");
            }
        }
        else if (answer.gameObject.name == "Answer_C")
        {
            if(gameManager.currentCorrect == gameManager.c){
                Debug.Log("You chose correct m8");

            } else { 
                Debug.Log("You chose wrong twerp");
            }            
            Debug.Log("Collision with Answer C");
        }
        else if (answer.gameObject.name == "Answer_D")
        {
            if(gameManager.currentCorrect == gameManager.d){
                Debug.Log("You chose correct m8");

            } else { 
                Debug.Log("You chose wrong twerp");
            }
            Debug.Log("Collision with Answer D");
        }
        else
        {
            Debug.Log("Stop hacking bruh");
        }
    }



}

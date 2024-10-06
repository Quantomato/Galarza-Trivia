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
        }
        else if (answer.gameObject.name == "Answer_B")
        {
            Debug.Log("Collision with Answer B");
        }
        else if (answer.gameObject.name == "Answer_C")
        {
            Debug.Log("Collision with Answer C");
        }
        else if (answer.gameObject.name == "Answer_D")
        {
            Debug.Log("Collision with Answer D");
        }
        else
        {
            Debug.Log("Stop hacking bruh");
        }
    }



}

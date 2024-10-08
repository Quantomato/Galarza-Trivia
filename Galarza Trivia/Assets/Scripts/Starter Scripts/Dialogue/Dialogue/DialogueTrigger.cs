﻿using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using System.IO.Pipes;

//A script by Michael O'Connell, extended by Benjamin Cohen


public class DialogueTrigger : MonoBehaviour
{
    //Attach this script to an empty gameobject with a 2D collider set to trigger
    DialogueManager manager;
    public TextAsset TextFileAsset; // your imported text file for your NPC
    private Queue<string> dialogue = new Queue<string>(); // stores the dialogue (Great Performance!)
    public float waitTime = 0.5f; // lag time for advancing dialogue so you can actually read it
    private float nextTime = 0f; // used with waitTime to create a timer system
    public bool singleUseDialogue = false;
    [HideInInspector]
    public bool hasBeenUsed = false;
    bool inArea = false;

    //Variables to make the NPC and Player move
    public GameObject NPC;
    public GameObject Player;
    private int hasTeleported = 0;

    // public bool useCollision; // unused for now

    private void Start()
    {
        manager = FindObjectOfType<DialogueManager>();
        //Writer
        string path = "Assets/Scripts/Starter Scripts/Dialogue/NPC_Interaction_1.txt";
        Debug.Log(path);
        using (var writer = new StreamWriter(path, false))
        {
            Debug.Log("Writing...");
            writer.WriteLine("[NAME=Player][SPEAKERSPRITE=Player] Where am I? Who are you?");
            writer.WriteLine("[NAME=????][SPEAKERSPRITE=????] Oh, a new person! Hello, I could really use your help.");
            writer.WriteLine("[NAME=Player][SPEAKERSPRITE=Player] I want to help you, but can you please tell me where we are first?");
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] Right, sorry; My name is Jahyr Galarza and we're in the mysterious Fey Forest.");
            writer.WriteLine("[NAME=Player][SPEAKERSPRITE=Player] Fey Forest? What's that?");
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] It's a magical forest controlled by faeries, and they trap people in here until they can finish a test.");
            writer.WriteLine("[NAME=Player][SPEAKERSPRITE=Player] What's the test that we need to do?");
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] We need to answer some questions about science, technology, engineering, and math. I didn't study much of that yet in school, so I was hoping you could help me.");
            writer.WriteLine("[NAME=Player][SPEAKERSPRITE=Player] Ok I think I can do that, how do I answer the questions?");
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] The questions will show up on your screen, and to input your answers just jump to the answer choice you want to pick.");
            writer.WriteLine("[NAME=Player][SPEAKERSPRITE=Player] Ok Galarza, I'll see if I can get us out of here.");
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] Good luck!");
            writer.Close();
        }
        AssetDatabase.Refresh();
    }


    private void Update()
    {
        if (!hasBeenUsed && inArea && Input.GetKeyDown(KeyCode.E) && nextTime < Time.timeSinceLevelLoad)
        {
            //Debug.Log("Advance");
            nextTime = Time.timeSinceLevelLoad + waitTime;
            manager.AdvanceDialogue();
        }
    }

    /* Called when you want to start dialogue */
    void TriggerDialogue()
    {
        ReadTextFile(); // loads in the text file
        manager.StartDialogue(dialogue); // Accesses Dialogue Manager and Starts Dialogue
    }

    /* loads in your text file */
    private void ReadTextFile()
    {
        string txt = TextFileAsset.text;

        string[] lines = txt.Split(System.Environment.NewLine.ToCharArray()); // Split dialogue lines by newline

        SearchForTags(lines);

        dialogue.Enqueue("EndQueue");
    }

    /*Version 2: Introduces the ability to have multiple tags on a single line! Allows for more functions to be programmed
     * to unique text strings or general functions. 
     */
    private void SearchForTags(string[] lines)
    {
        foreach (string line in lines) // for every line of dialogue
        {
            if (!string.IsNullOrEmpty(line))// ignore empty lines of dialogue
            {
                if (line.StartsWith("[")) // e.g [NAME=Michael] Hello, my name is Michael
                {
                    string special = line.Substring(0, line.IndexOf(']') + 1); // special = [NAME=Michael]
                    string curr = line.Substring(line.IndexOf(']') + 1); // curr = Hello, ...
                    dialogue.Enqueue(special); // adds to the dialogue to be printed
                    string[] remainder = curr.Split(System.Environment.NewLine.ToCharArray());
                    SearchForTags(remainder);
                    //dialogue.Enqueue(curr);
                }

                else
                {
                    dialogue.Enqueue(line); // adds to the dialogue to be printed
                }
            }
        }

    }

    public void UpdateText(string question, string a1, string a2, string a3, string a4)
    {
        string path = "Assets/Scripts/Starter Scripts/Dialogue/NPC_Interaction_1.txt";
        Debug.Log(path);
        using (var writer = new StreamWriter(path, false))
        {
            Debug.Log("Writing...");
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] Alright, here's your question: ");
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] " + question);
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] Here are your answer choices: ");
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] A. " + a1);
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] B. " + a2);
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] C. " + a3);
            writer.WriteLine("[NAME=Galarza][SPEAKERSPRITE=Galarza] D. " + a4);
            writer.Close();
        }
        AssetDatabase.Refresh();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !hasBeenUsed)
        {
            manager.currentTrigger = this;
            TriggerDialogue();
            //Debug.Log("Collision");
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            inArea = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.EndDialogue();
            NPC.transform.position = new Vector2(1.805f, -0.484f);
            if (hasTeleported < 2)
            {
                hasTeleported+=1;
                
            }
            else
            {
                Player.transform.position = new Vector2(2.223235f, 0.4716103f);
            }
        }
        inArea = false;
    }
}

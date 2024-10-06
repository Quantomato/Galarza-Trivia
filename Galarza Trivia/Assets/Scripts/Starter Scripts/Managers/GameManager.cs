using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<Questions> questionList = new List<Questions>();
    List<int> askedQuestionIndexList = new List<int>();
    Questions currentQuestion;
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
   //Create the questions
    Questions q1 = new Questions("What unit is electric power measured in?", "Watts", "Ohms", "Newtons", "Fractals");
    Questions q2 = new Questions("What is the name of the scientist who discovered gravity?", "Isaac Newton", "Robert Oppenheimer", "Albert Einstein", "Benjamin Franklin");
    Questions q3 = new Questions("What is the name of the galaxy we live in?", "The Milky Way", "The Pinwheel", "The Andromeda", "The Triangulum");
    Questions q4 = new Questions("What medicine is commonly used to treat bacteria?", " Antibiotics", "Vaccines", "Antiseptics", "Neosporin");
    Questions q5 = new Questions("What are the base instructions for all life?", "DNA", "RNA", "MRNA", "PNA");
    Questions q6 = new Questions("What allows plants to make their own food?", "Chlorophyll", "Mitochondria", "Ribosomes", "Byzantium");
    Questions q7 = new Questions("What is the most common element in the universe?", "Hydrogen", "Oxygen", "Carbon", "Matter");
    Questions q8 = new Questions("What molecule allows us to breathe on Earth?", "Oxygen", "Hydrogen", "Helium", "Nitrogen");
    Questions q9 = new Questions("What are molecules made of?", "Atoms", "Cubes", "Cones", "Functions");
    Questions q10 = new Questions("What is the closest planet to the Sun?", "Mercury", "Earth", "Venus", "Pluto");
    Questions q11 = new Questions("What component of a computer does the thinking?", "CPU", "GPU", "JPU", "MPU");
    Questions q12 = new Questions("Who was the first computer programmer?", "Ada Lovelace", "Alan Turing", "Edward Dijkstra", "Bill Gates");
    Questions q13 = new Questions("What key on a keyboard works like an eraser?", "Backspace", "Space", "Shift", "Control");
    Questions q14 = new Questions("Who invented the first mechanical computer?", "Charles Babbage", "Blaise Pascal", "Robert Floyd", "Albert Kleene");
    Questions q15 = new Questions("Who founded Apple?", "Steve Jobs", "Bill Gates", "Bernard Roy", "Stephen Apple");
    Questions q16 = new Questions("Who was the creator of Windows?", "Bill Gates", "Xavier Microsoft", "John Windows", "Linus Torvald");
    Questions q17 = new Questions("What does GB stand for?", "Gigabyte", "Game Boy", "General Business", "Gasoline Ballast");
    Questions q18 = new Questions("What component stores data in a computer?", "Hard drive", "monitor", "keyboard", "mouse");
    Questions q19 = new Questions("When was the first computer made?", "1822", "1776", "1873", "2005");
    Questions q20 = new Questions("How many keys does a US keyboard have?", "104", "26", "57", "125");
    Questions q21 = new Questions("When you hold something in the air, what type of energy is acting on the force?", "Potential energy", "kinetic energy", "electrical energy", "life energy");
    Questions q22 = new Questions("What is the acceleration of gravity on earth in meters per second?", "9.8", "12", "50.4", "1000");
    Questions q23 = new Questions("What type of metal is used to be very malleable and light?", "Aluminum", "Steel", "Gold", "Diamond");
    Questions q24 = new Questions("What material is used in cars to fuel them?", "Gasoline", "Water", "Rocket Fuel", "Apple Juice");
    Questions q25 = new Questions("What force brings objects towards the ground?", "Gravity", "Strong Nuclear Force", "Electricity", "Power of Friendship");
    Questions q26 = new Questions("Who built the first car?", "Karl Benz", "George Washington", "Albert Einstein", "Barack Obama");
    Questions q27 = new Questions("What force slows down things in contact and creates heat?", "Friction", "Temperature", "Gravity", "Willpower");
    Questions q28 = new Questions("Each force has an equal and opposite ____ :", "Reaction", "Force", "direction", "size");
    Questions q29 = new Questions("What is the science behind heat called:", "Thermodynamics", "Heatology", "Chemistry", "sociology");
    Questions q30 = new Questions("What is it called when you are fast enough to enter space from earth:", "escape velocity", "light speed", "hypersonic", "pretty fast");
    Questions q31 = new Questions("What is 9 + 10:", "19", "21", "17", "-3");
    Questions q32 = new Questions("What is 3 x 3:", "9", "10", "33", "3");
    Questions q33 = new Questions("What is 40013 x 0:", "0", "43", "1", "400032");
    Questions q34 = new Questions("What is 5-3:", "2", "1", "4", "3");
    Questions q35 = new Questions("What is 5 x 12:", "60", "40", "12", "21");
    Questions q36 = new Questions("What is 3/5 + 4/10?", "1", "7/15", "12/50", "1/5");
    Questions q37 = new Questions("What is 1000 / 2?", "500", "32", "2000", "0");
    Questions q38 = new Questions("What is 2 to the power of 2?", "4", "5", "22", "2");
    Questions q39 = new Questions("What is 30/2", "15", "54", "23", "40");
    Questions q40 = new Questions("What is 1 x 43?", "43", "1", "34", "40");
    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = FindObjectOfType<PlayerMovement>().gameObject;
        }
        RespawnPlace = Player.transform.position;

        currentQuestion = new Questions("test", "a", "b", "c", "d");
        //Create the question list
        questionList = addQuestions(questionList);
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
        currentQuestion = new Questions(questionList[findNumber]);
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

    public List<Questions> addQuestions(List<Questions> array)
        {
            array.Add(q1);
            array.Add(q2);
            array.Add(q3);
            array.Add(q4);
            array.Add(q5);
            array.Add(q6);
            array.Add(q7);
            array.Add(q8);
            array.Add(q9);
            array.Add(q10);
            array.Add(q11);
            array.Add(q12);
            array.Add(q13);
            array.Add(q14);
            array.Add(q15);
            array.Add(q16);
            array.Add(q17);
            array.Add(q18);
            array.Add(q19);
            array.Add(q20);
            array.Add(q21);
            array.Add(q22);
            array.Add(q23);
            array.Add(q24);
            array.Add(q25);
            array.Add(q26);
            array.Add(q27);
            array.Add(q28);
            array.Add(q29);
            array.Add(q30);
            array.Add(q31);
            array.Add(q32);
            array.Add(q33);
            array.Add(q34);
            array.Add(q35);
            array.Add(q36);
            array.Add(q37);
            array.Add(q38);
            array.Add(q39);
            array.Add(q40);
            return array;
        }
}


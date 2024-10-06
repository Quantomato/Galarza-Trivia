using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class listOfQuestions
{
    question[] questionList = new question[10];

    question science0 = new question("What unit is electric power measured in?",
        new string[] { "Watts", "Ohms", "Newtons", "Fractals" });
    question science1 = new question("What is the name of the scientist who discovered gravity?",
        new string[] { "Isaac Newton", "Robert Oppenheimer", "Albert Einstein", "Benjamin Franklin" });
    question science2 = new question("What is the name of the galaxy we live in?",
        new string[] { "The Milky Way", "The Pinwheel", "The Andromeda", "The Triangulum" });
    question science3 = new question("What medicine is commonly used to treat bacteria?",
        new string[] { "Antibiotics", "Vaccines", "Antiseptics", "Neosporin" });
    question science4 = new question("What are the base instructions for all life?",
        new string[] { "DNA", "RNA", "MRNA", "PNA" });
    question science5 = new question("What allows plants to make their own food?",
        new string[] { "Chlorophyll", "Mitochondria", "Ribosomes", "Byzantium" });
    question science6 = new question("What is the most common element in the universe?",
        new string[] { "Hydrogen", "Oxygen", "Carbon", "Matter" });
    question science7 = new question("What molecule allows us to breathe on Earth?",
        new string[] { "Oxygen", "Hydrogen", "Helium", "Nitrogen" });
    question science8 = new question("What are molecules made of?",
        new string[] { "Atoms", "Cubes", "Cones", "Functions" });
    question science9 = new question("What is the closest planet to the Sun?",
        new string[] { "Mercury", "Earth", "Venus", "Pluto" });
    public question findScience(int num)
    {
        if (num == 0) { return science0; }
        else if (num == 1) { return science1; }
        else if (num == 2) { return science2; }
        else if (num == 3) { return science3; }
        else if (num == 4) { return science4; }
        else if (num == 5) { return science5; }
        else if (num == 6) { return science6; }
        else if (num == 7) { return science7; }
        else if (num == 8) { return science8; }
        else if (num == 9) { return science9; }
        else
        {
            Console.WriteLine("HELP ME IN LIST OF QUESTIONS, SCIENCE");
            return science0;
        }
    }

    public listOfQuestions()
    {
        for (int i = 0; i < 10; i++)
        {
            questionList[i] = findScience(i);
        }
    }
}

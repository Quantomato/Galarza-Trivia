using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listOfQuestions
{
    string question = "";
    string[] answers;

    public listOfQuestions(String q, String a0, String a1, String a2, String a3)
        {
        question = q;
        answers[0] = a0;
        answers[1] = a1;
        answers[2] = a2;
        answers[3] = a3;
        }

    public listOfQuestions(listOfQuestions copy) 
    { 
        this.question = copy.question;
        this.answers[0] = copy.answers[0];
        this.answers[1] = copy.answers[1];
        this.answers[2] = copy.answers[2];
        this.answers[3] = copy.answers[3];
    }
        listOfQuestions q1 = new listOfQuestions("What unit is electric power measured in?", "Watts", "Ohms", "Newtons", "Fractals");
        listOfQuestions q2 = new listOfQuestions("What is the name of the scientist who discovered gravity?", "Isaac Newton", "Robert Oppenheimer", "Albert Einstein", "Benjamin Franklin");
        listOfQuestions q3 = new listOfQuestions("What is the name of the galaxy we live in?", "The Milky Way", "The Pinwheel", "The Andromeda", "The Triangulum");
        listOfQuestions q4 = new listOfQuestions("What medicine is commonly used to treat bacteria?", " Antibiotics", "Vaccines", "Antiseptics", "Neosporin");
        listOfQuestions q5 = new listOfQuestions("What are the base instructions for all life?", "DNA", "RNA", "MRNA", "PNA");
        listOfQuestions q6 = new listOfQuestions("What allows plants to make their own food?", "Chlorophyll", "Mitochondria", "Ribosomes", "Byzantium");
        listOfQuestions q7 = new listOfQuestions("What is the most common element in the universe?", "Hydrogen", "Oxygen", "Carbon", "Matter");
        listOfQuestions q8 = new listOfQuestions("What molecule allows us to breathe on Earth?", "Oxygen", "Hydrogen", "Helium", "Nitrogen");
        listOfQuestions q9 = new listOfQuestions("What are molecules made of?", "Atoms", "Cubes", "Cones", "Functions");
        listOfQuestions q10 = new listOfQuestions("What is the closest planet to the Sun?", "Mercury", "Earth", "Venus", "Pluto");
        listOfQuestions q11 = new listOfQuestions("What component of a computer does the thinking?", "CPU", "GPU", "JPU", "MPU");
        listOfQuestions q12 = new listOfQuestions("Who was the first computer programmer?", "Ada Lovelace", "Alan Turing", "Edward Dijkstra", "Bill Gates");
        listOfQuestions q13 = new listOfQuestions("What key on a keyboard works like an eraser?", "Backspace", "Space", "Shift", "Control");
        listOfQuestions q14 = new listOfQuestions("Who invented the first mechanical computer?", "Charles Babbage", "Blaise Pascal", "Robert Floyd", "Albert Kleene");
        listOfQuestions q15 = new listOfQuestions("Who founded Apple?", "Steve Jobs", "Bill Gates", "Bernard Roy", "Stephen Apple");
        listOfQuestions q16 = new listOfQuestions("Who was the creator of Windows?", "Bill Gates", "Xavier Microsoft", "John Windows", "Linus Torvald");
        listOfQuestions q17 = new listOfQuestions("What does GB stand for?", "Gigabyte", "Game Boy", "General Business", "Gasoline Ballast");
        listOfQuestions q18 = new listOfQuestions("What component stores data in a computer?", "Hard drive", "monitor", "keyboard", "mouse");
        listOfQuestions q19 = new listOfQuestions("When was the first computer made?", "1822", "1776", "1873", "2005");
        listOfQuestions q20 = new listOfQuestions("How many keys does a US keyboard have?", "104", "26", "57", "125");
        listOfQuestions q21 = new listOfQuestions("When you hold something in the air, what type of energy is acting on the force?", "Potential energy", "kinetic energy", "electrical energy", "life energy");
        listOfQuestions q22 = new listOfQuestions("What is the acceleration of gravity on earth in meters per second?", "9.8", "12", "50.4", "1000");
        listOfQuestions q23 = new listOfQuestions("What type of metal is used to be very malleable and light?", "Aluminum", "Steel", "Gold", "Diamond");
        listOfQuestions q24 = new listOfQuestions("What material is used in cars to fuel them?", "Gasoline", "Water", "Rocket Fuel", "Apple Juice");
        listOfQuestions q25 = new listOfQuestions("What force brings objects towards the ground?", "Gravity", "Strong Nuclear Force", "Electricity", "Power of Friendship");
        listOfQuestions q26 = new listOfQuestions("Who built the first car?", "Karl Benz", "George Washington", "Albert Einstein", "Barack Obama");
        listOfQuestions q27 = new listOfQuestions("What force slows down things in contact and creates heat?", "Friction", "Temperature", "Gravity", "Willpower");
        listOfQuestions q28 = new listOfQuestions("Each force has an equal and opposite ____ :", "Reaction", "Force", "direction", "size");
        listOfQuestions q29 = new listOfQuestions("What is the science behind heat called:", "Thermodynamics", "Heatology", "Chemistry", "sociology");
        listOfQuestions q30 = new listOfQuestions("What is it called when you are fast enough to enter space from earth:", "escape velocity", "light speed", "hypersonic", "pretty fast");
        listOfQuestions q31 = new listOfQuestions("What is 9 + 10:", "19", "21", "17", "-3");
        listOfQuestions q32 = new listOfQuestions("What is 3 x 3:", "9", "10", "33", "3");
        listOfQuestions q33 = new listOfQuestions("What is 40013 x 0:", "0", "43", "1", "400032");
        listOfQuestions q34 = new listOfQuestions("What is 5-3:", "2", "1", "4", "3");
        listOfQuestions q35 = new listOfQuestions("What is 5 x 12:", "60", "40", "12", "21");
        listOfQuestions q36 = new listOfQuestions("What is 3/5 + 4/10?", "1", "7/15", "12/50", "1/5");
        listOfQuestions q37 = new listOfQuestions("What is 1000 / 2?", "500", "32", "2000", "0");
        listOfQuestions q38 = new listOfQuestions("What is 2 to the power of 2?", "4", "5", "22", "2");
        listOfQuestions q39 = new listOfQuestions("What is 30/2", "15", "54", "23", "40");
        listOfQuestions q40 = new listOfQuestions("What is 1 x 43?", "43", "1", "34", "40");
        public void addQuestions(List<listOfQuestions> array)
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
        }

    }


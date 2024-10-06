using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour {

    public AudioSource Wrong;
    public AudioSource Correct;

    public void PlayWrong() {
        Wrong.Play();
    }

    public void PlayCorrect() {
        Correct.Play();
    }


}
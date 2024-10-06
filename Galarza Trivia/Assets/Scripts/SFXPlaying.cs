using system.Collections;
using system.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour {

    public AudioSource Wrong;
    public AudioSource Correct;

    public void PlayWrong() {
        Wrong.play();
    }

    public void PlayCorrect() {
        Correct.play();
    }


}
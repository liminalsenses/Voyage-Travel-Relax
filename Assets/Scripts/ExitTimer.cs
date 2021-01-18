using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitTimer : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 
    public GameObject timerText;
    public Button exitButton1;
    public Button exitButton2;
    public Button exitButton3;
    public Button exitButton4;
    public Button exitButton5;
    public Button exitButton6;
    public Button exitButton7;
    public Button exitButton8;
    public Button exitButton9;
    public Button exitButton10;
    public Button exitButton11;
    public Button exitButton12;
    public Button exitButton13;
    public Button exitButton14;



    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            //Do something useful or Load a new game scene depending on your use-case
            timerText.SetActive(false);
            exitButton1.interactable = true;
            exitButton2.interactable = true;
            exitButton3.interactable = true;
            exitButton4.interactable = true;
            exitButton5.interactable = true;
            exitButton6.interactable = true;
            exitButton7.interactable = true;
            exitButton8.interactable = true;
            exitButton9.interactable = true;
            exitButton10.interactable = true;
            exitButton11.interactable = true;
            exitButton12.interactable = true;
            exitButton13.interactable = true;
            exitButton14.interactable = true;
        }
    }
}

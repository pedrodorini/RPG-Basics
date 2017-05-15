﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;
    public bool dialogueActive;
    public string[] dialogueLines;
    public int currentLine;
    private PlayerController thePlayer;

    // Use this for initialization
    void Start() {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update() {
        if (dialogueActive && Input.GetKeyUp(KeyCode.Space)) {
            currentLine++;
        }
        if (currentLine >= dialogueLines.Length) {
            dBox.SetActive(false);
            dialogueActive = false;
            thePlayer.canMove = true;
            
            currentLine = 0;
        }
        dText.text = dialogueLines[currentLine];
    }

    public void showBox(string dialogue) {
        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }
    
    public void showDialogue() {
        dialogueActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }
}

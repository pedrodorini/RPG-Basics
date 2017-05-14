using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {

    public QuestObject[] quests;
    public bool[] questCompleted;
    public DialogueManager theDm;


    // Use this for initialization
    void Start () {
        questCompleted = new bool[quests.Length];
            
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showQuestText(string questText) {
        theDm.dialogueLines = new string[1];
        theDm.dialogueLines[0] = questText;
        theDm.currentLine = 0;
        theDm.showDialogue();
    }
}

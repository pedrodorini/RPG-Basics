using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    public int questNumber;
    public QuestManager theQm;
    public string startText;
    public string endText;
    public bool isItemQuest;
    public string targetItem;
    public bool isEnemyQuest;
    public string targetEnemy;
    public int enemiesToKill;
    private int enemyToKillCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isItemQuest) {
            if(theQm.itemCollected == targetItem) {
                theQm.itemCollected = null;
                endQuest();
            }
        }
        if (isEnemyQuest) {
            if(theQm.enemyKilled == targetEnemy) {
                theQm.enemyKilled = null;
                enemyToKillCount++;
            }
            if(enemyToKillCount >= enemiesToKill) {
                endQuest();
            }
        }
	}

    public void startQuest() {
        theQm.showQuestText(startText);
    }

    public void endQuest() {
        theQm.showQuestText(endText);
        theQm.questCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}

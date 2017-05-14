using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;
    public int currentExp;
    public int[] toLevelUp;
    public int[] HPLevels;
    public int[] attackLevels;
    public int[] defencesLevels;
    public int currentHP;
    public int currentAttack;
    public int currentDefence;
    private PlayerHealthManager thePlayerHealth;

	// Use this for initialization
	void Start () {
        currentHP = HPLevels[1];
        currentAttack = attackLevels[1];
        currentDefence = defencesLevels[1];
        thePlayerHealth = FindObjectOfType<PlayerHealthManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(currentExp >= toLevelUp[currentLevel]) {
            levelUp();
        }
	}

    public void addExperience(int experienceToAdd) {
        currentExp += experienceToAdd;
    }
    
    public void levelUp() {
        currentLevel++;
        currentHP = HPLevels[currentLevel];
        thePlayerHealth.playerMaxHealth = currentHP;
        thePlayerHealth.playerCurrentHealth += (currentHP - HPLevels[currentLevel]);
        currentAttack = attackLevels[currentLevel];
        currentDefence = defencesLevels[currentLevel];


    }
}

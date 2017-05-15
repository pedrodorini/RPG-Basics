using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHealth;
    private PlayerStats thePlayerStats;
    public int expToGive;
    public string enemyQuestName;
    private QuestManager theQm;

    // Use this for initialization
    void Start() {
        CurrentHealth = MaxHealth;
        
        thePlayerStats = FindObjectOfType<PlayerStats>();
        theQm = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update(){
        if (CurrentHealth <= 0) {
            theQm.enemyKilled = enemyQuestName;
            Destroy(gameObject);
            thePlayerStats.addExperience(expToGive);
        }
    }

    public void HurtEnemy(int damageToGive) {
        CurrentHealth -= damageToGive;
    }

    public void setMaxHealth() {
        CurrentHealth = MaxHealth;
    }
}

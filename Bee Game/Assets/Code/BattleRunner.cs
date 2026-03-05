using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleRunner : MonoBehaviour
{
    public GameObject soldierBeeObject;
    public GameObject enemyObject;
    private List<ISoldier> allies = new List<ISoldier>();
    private List<ISoldier> enemies = new List<ISoldier>();
    void Awake()
    {
    }
    public void addBee(SoldierBee bee)
    {
        ISoldier beeSoldier = (ISoldier) bee;
        beeSoldier.Initialize();
        allies.Add(beeSoldier);
    }
    public void addEnemy(Enemy enemy)
    {
        ISoldier enemySoldier = (ISoldier) enemy;
        enemySoldier.Initialize();
        enemies.Add(enemySoldier);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void startBattle()
    {
        List<ISoldier> priorityOrder = new List<ISoldier>();
        priorityOrder.AddRange(allies);
        priorityOrder.AddRange(enemies);
        priorityOrder.Sort();
        bool oneSideDied = false;
        float damage = 0;
        while (!oneSideDied)
        {
            for (int i = 0; i < priorityOrder.Count; i++)
            {
                ISoldier currentSoldier = priorityOrder[i];
                currentSoldier.takeDamage(damage);
                //Debug.Log(currentSoldier + " " + currentSoldier.getSpeed());
                damage = currentSoldier.onTurnStart();
                oneSideDied = currentSoldier.isDead();
            }
        }
    }
}

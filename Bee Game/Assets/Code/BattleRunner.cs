using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleRunner : MonoBehaviour
{
    public GameObject soldierBeeObject;
    public GameObject enemyObject;
    void Awake()
    {
        ISoldier bee = soldierBeeObject.GetComponent<ISoldier>();
        bee.Initialize();
        ISoldier enemy = enemyObject.GetComponent<ISoldier>();
        enemy.Initialize();
        List<ISoldier> allies = new List<ISoldier>();
        List<ISoldier> enemies = new List<ISoldier>();
        allies.Add(bee);
        enemies.Add(enemy);
        startBattle(allies,enemies);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void startBattle(List<ISoldier> allies, List<ISoldier> enemies)
    {
        List<ISoldier> priorityOrder = new List<ISoldier>();
        priorityOrder.AddRange(allies);
        priorityOrder.AddRange(enemies);
        priorityOrder.Sort();
        bool oneSideDied = false;
        while (!oneSideDied)
        {
            for (int i = 0; i < priorityOrder.Count; i++)
            {
                ISoldier currentSoldier = priorityOrder[i];
                Debug.Log(currentSoldier + " " + currentSoldier.getSpeed());
                currentSoldier.onTurnStart();
                oneSideDied = currentSoldier.isDead();
            }
        }
    }
}

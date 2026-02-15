using System.Collections.Generic;
using UnityEngine;

public class Beetle : MonoBehaviour, ISoldier
{
    public string myName;
    public float maxHp = 10;
    public int dodgeChance = 20;
    public float damage = 1;
    public float moveSpeed = 5;
    private IBrain controller;
    private List<Ability> abilities = new List<Ability>();
    private Enemy enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Initialize()
    {
        controller = GetComponent<IBrain>();
        enemy = new Enemy(maxHp, damage, dodgeChance, moveSpeed);
        Ability headBash = new HeadBash();
        headBash.initialize();
        abilities.Add(headBash);
        Debug.Log(enemy);

    }
    public string getName() { return myName; }
    public List<Ability> getAbilities() { return abilities; }
    public  void takeDamage(float damage) 
    { 
        enemy.takeDamage(damage);
    }
    public float onTurnStart() 
    {
        int action = controller.chooseAction(this);
        Ability ability = abilities[action];
        return ability.attack(damage);
        //ability.changeStat(enemy);
    }
    public float getSpeed()
    {
        return moveSpeed;
    }
    public bool isDead()
    {
        //Debug.Log(enemy);
        return !enemy.isAlive();
    }
    public int CompareTo(ISoldier other)
    {
        return moveSpeed.CompareTo(other.getSpeed());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class RogueBee : MonoBehaviour, ISoldier
{
    public string myName;
    public float maxHp = 10;
    public int maxCarryWeight = 2;
    public int dodgeChance = 20;
    public float damage = 1;
    public float moveSpeed = 5;
    public float floatspeed =2;
    private IBrain controller;  
    private SoldierBee rogueBee;
    private Ability suicideStrike;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Initialize()
    {
        controller = GetComponent<IBrain>();
        suicideStrike = new SuicideStrike();
        suicideStrike.initialize();
        rogueBee = new SoldierBee(maxCarryWeight, maxHp, damage, dodgeChance, moveSpeed, floatspeed);
        rogueBee.Abilities.Add(suicideStrike);
    }
    public void takeDamage(float damage)
    {
        rogueBee.takeDamage(damage);
    }
    public float onTurnStart()
    {
        int action = controller.chooseAction(this);
        Ability ability = rogueBee.Abilities[action];
        ability.changeStat(rogueBee);
        return ability.attack(damage);
    }
    public virtual string getName() { return myName; }
    public List<Ability> getAbilities() { return rogueBee.Abilities; }
    public bool isDead() { return !rogueBee.isAlive();}
    // Update is called once per frame
    void Update()  
    {
        
    }

    public int CompareTo(ISoldier other)
    {
        return moveSpeed.CompareTo(other.getSpeed());

    }
}

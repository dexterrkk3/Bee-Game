using UnityEngine;

public class Ability
{
    private string name; 
    private string description;
    private float mult;
    public virtual void initialize() { }
    public virtual float attack(float damage)
    {
        return damage * mult; 
    }
    public virtual void changeStat(SoldierBee bee)
    {

    }
    public string getDescription() {return description;}
    public string getName () {return name;}
    public float getMult() {return mult;}
}

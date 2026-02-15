using UnityEngine;

public class SuicideStrike : Ability
{
    private string name;
    private string description;
    private float mult;
    public override float attack(float damage)
    {
        return damage *5; 
    }
    public override void changeStat(SoldierBee bee)
    {
        bee.takeDamage(100);
    }
}

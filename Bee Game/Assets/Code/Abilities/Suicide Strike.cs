using UnityEngine;

public class SuicideStrike : Ability
{
    public override float attack(float damage)
    {
        return damage *5; 
    }
    public override void changeStat(SoldierBee bee)
    {
        bee.takeDamage(100);
    }
}

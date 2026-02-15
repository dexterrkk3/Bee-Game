using UnityEngine;

public class SuicideStrike : Ability
{
    private string name;
    private string description;
    private float mult;
    public void initialize()
    {
        name = "Suicide Strike";
        description = "Hit them with your stinger. I know you want to.";
        mult = 5;
    }
    public override float attack(float damage)
    {
        return damage *mult; 
    }
    public override void changeStat(SoldierBee bee)
    {
        bee.takeDamage(100);
    }
}

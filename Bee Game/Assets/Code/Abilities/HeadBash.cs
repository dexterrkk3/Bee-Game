using UnityEngine;

public class HeadBash : Ability
{
    private string name = "HeadBash";
    private string description= "Slam into the enemy at high speed";
    private float mult = 1.5f;
    public override void initialize()
    {
        name = "HeadBash";
        description = "Slam into the enemy at high speed";
        mult = 1.5f;
    }
    public override float attack(float damage)
    {
        return damage * mult;
    }
    public override void changeStat(SoldierBee bee)
    {

    }
}

using UnityEngine;

public class HeadBash : Ability
{
    private string name = "HeadBash";
    private string description= "Slam into the enemy at high speed";
    private float mult = 1.5f;
    public void initialize()
    {
        name = "HeadBash";
        description = "Slam into the enemy at high speed";
        mult = 1.5f;
    }
}

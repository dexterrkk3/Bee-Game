using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SoldierBee : WorkerBee
{
    public List<Ability> Abilities = new List<Ability>();
    public SoldierBee(int maxCarryWeight, float hp, float damage, float dodgeChance, float moveSpeed, float flySpeed) : base(maxCarryWeight, hp, damage, dodgeChance, moveSpeed, flySpeed)
    {
    }
    void assignAbilities(List<Ability> abilities)
    {
        Abilities = abilities;
    }
}

using UnityEngine;
[System.Serializable]
public class WorkerBee : Bee
{
    bool containsPollen;
    int carryWeight;
    int pollenAmount; 
    public WorkerBee(int maxCarryWeight, float hp, float damage, float dodgeChance, float moveSpeed, float flySpeed) : base(hp, damage, dodgeChance, moveSpeed, flySpeed)
    {
        containsPollen = false;
        carryWeight = maxCarryWeight;
    }
    public virtual void harvestFlower(int pollenFlower)
    {
        containsPollen = true;
        if(carryWeight +pollenAmount> pollenFlower)
        {
            pollenAmount = carryWeight;
        }
        else
        {
            pollenAmount = pollenFlower;
        }
    }
}

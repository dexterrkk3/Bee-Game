using UnityEngine;

public class RogueBee : MonoBehaviour
{
    public float maxHp = 10;
    public int maxCarryWeight = 2;
    public int dodgeChance = 20;
    public float damage = 1;
    public float moveSpeed = 5;
    public float floatspeed =2; 
    public SoldierBee rogueBee;
    public Ability suicideStrike;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        suicideStrike = new SuicideStrike();
        rogueBee = new SoldierBee(maxCarryWeight, maxHp, damage, dodgeChance, moveSpeed, floatspeed);
        rogueBee.Abilities.Add(suicideStrike);
    }
    void takeDamage(int damage)
    {
        rogueBee.takeDamage(damage);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

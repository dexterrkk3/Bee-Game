using UnityEngine;
[System.Serializable]

public class Bee
{
    private float hp;
    private float maxHp;
    private float damage; 
    private float dodgeChance; 
    private float moveSpeed;
    private float flySpeed;
    private bool alive;
    public Bee(float hp, float damage, float dodgeChance, float moveSpeed, float flySpeed)
    {
        this.hp = hp;
        maxHp = hp;
        this.damage = damage;
        this.dodgeChance = dodgeChance;
        this.moveSpeed = moveSpeed;
        this.flySpeed = flySpeed;
        alive = true;
    }
    public virtual void takeDamage(float damage)
    {
        float x = Random.Range(0, 100);
        if (x < dodgeChance)
        {
            hp -= damage;
        }
        if(hp <= 0)
        {
            die();
        }
    }
    private void die()
    {
        alive = false;
    }
}

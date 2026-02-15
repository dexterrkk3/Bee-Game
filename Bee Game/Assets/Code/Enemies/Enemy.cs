using UnityEngine;

[SerializeField]
public class Enemy
{
    private float hp;
    private float maxHp;
    private float damage;
    private float dodgeChance;
    private float moveSpeed;
    private bool alive;
    public Enemy(float hp, float damage, float dodgeChance, float moveSpeed)
    {
        this.hp = hp;
        maxHp = hp;
        this.damage = damage;
        this.dodgeChance = dodgeChance;
        this.moveSpeed = moveSpeed;
        alive = true;
    }
    public virtual void takeDamage(float damage)
    {
        float x = Random.Range(0, 100);
        if (x < dodgeChance)
        {
            hp -= damage;
        }
        Debug.Log(hp);
        if (hp <= 0)
        {
            die();
        }
    }
    public bool isAlive() { return alive; } 
    private void die()
    {
        alive = false;
    }
}

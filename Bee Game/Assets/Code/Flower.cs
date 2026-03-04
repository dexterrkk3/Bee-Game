using UnityEngine;

public class Flower
{
    private string enemyName;
    private Pollen pollen;
    public virtual Pollen getPollen()
    {
        return  pollen;
    }
    public virtual string getEnemyName()
    {
        return "NA";
    }
}

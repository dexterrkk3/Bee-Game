using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public BattleRunner runner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }
    public void startCombat()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

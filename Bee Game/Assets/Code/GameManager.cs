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
    public GameObject spawnCreature(string characterName)
    {
        Debug.Log("Spawned: " + characterName);
        return Resources.Load<GameObject>(characterName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class RandomBrain : MonoBehaviour, IBrain
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int chooseAction(ISoldier soldier)
    {
        List<Ability> abilities = soldier.getAbilities();
        Debug.Log(abilities.Count);
        for (int i = 0; i < abilities.Count; i++)
        {
            //lists all abilities
            Ability ability = abilities[i];
            Debug.Log(ability.getName());
        }
        //picks a random action
        int rand = Random.Range(0, abilities.Count);
        return rand;
    }
}

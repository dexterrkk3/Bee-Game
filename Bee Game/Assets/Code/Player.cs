using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<SoldierBee> soldiers;
    public GameObject beeObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soldiers = new List<SoldierBee>();
        soldiers = beeObject.GetComponentsInChildren<SoldierBee>().ToList();
    }
    public void sendbee(SoldierBee bee, Flower flower)
    {
        GameManager.instance.sendBee(bee, flower);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public interface ISoldier: IComparable<ISoldier>
{
    public virtual void Initialize()
    {

    }
   public virtual string getName() { return "none"; }
   public List<Ability> getAbilities() { return new List<Ability>(); }
   public virtual void takeDamage(float damage) { }
   public virtual void onTurnStart() { }
   public virtual float getSpeed() { return 0;}
   public virtual bool isDead() { return true; }
   public int CompareTo(ISoldier soldier)
   {
       return getSpeed().CompareTo(soldier.getSpeed());
   } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewPool" , menuName ="CreatPool/NewPool")]
public class PoolScriptableObject : ScriptableObject
{
   public List<GameObject> Coins;
   public List<GameObject> Zombie;


    void OnEnable()
    {
        if(Coins.Count > 0 || Zombie.Count > 0)
        {
            Coins.Clear();
            Zombie.Clear();
        }
    }



}

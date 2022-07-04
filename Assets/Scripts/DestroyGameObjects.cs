
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Pool;
using Main;
public class DestroyGameObjects : MonoBehaviour
{
    PoolManager poolManager;
    void Start()
    {
        poolManager = GameManager.instance.poolManager;
    }
    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            poolManager.poolScriptableObject.Coins.Add(other.gameObject);
            
        }
    }
}

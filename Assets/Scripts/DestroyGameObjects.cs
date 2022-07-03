
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjects : MonoBehaviour
{
    PoolManager poolManager;
    void Start()
    {
        poolManager = PoolManager.instance;
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

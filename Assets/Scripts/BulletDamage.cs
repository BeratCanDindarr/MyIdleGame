using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main;
public class BulletDamage : MonoBehaviour
{
    public float damage;
    PoolScriptableObject poolScriptableObject;

    public float timer = 10;
    float _timer;
    bool onEnabled = false;
    void Start()
    {
        poolScriptableObject = GameManager.instance.poolManager.poolScriptableObject;
        timerReset();
    }
    void OnEnable()
    {
        onEnabled = true;
    }
    void Update()
    {
        if(onEnabled)
        {
            _timer = GameManager.instance.Timer(_timer);
            if(_timer <= 0 )
            {
                ReturnScriptableObject();
                timerReset();
            }
        }
    }
    void OnDisable()
    {
        onEnabled = false;
        timerReset();
    }
    
    void timerReset()
    {
        _timer = timer;
    }
   void OnTriggerEnter(Collider other)
   {
       var Idamage = other.gameObject.GetComponent<IDamageAble<float>>();
       if(Idamage != null)
       {
        Idamage.Damage(damage);
       }
       ReturnScriptableObject();
       
   }

   void ReturnScriptableObject()
   {
    gameObject.SetActive(false);
       
       poolScriptableObject.Bullet.Add(gameObject);
       gameObject.transform.position = new Vector3(0,-10,0);
   }
 
}

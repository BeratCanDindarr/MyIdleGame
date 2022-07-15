using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public float damage;
   void OnTriggerEnter(Collider other)
   {
       var Idamage = other.gameObject.GetComponent<IDamageAble<float>>();
       if(Idamage != null)
       {
        Idamage.Damage(damage);
       }
       Destroy(gameObject);
   }
}

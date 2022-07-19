using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main.Shoot
{
    public class Shooting : MonoBehaviour
    {
        GameObject bullet;

        public float bulletSpeed;
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void Shot(Transform gunBarrel)
        {
           GameObject _bullet = GameManager.instance.poolManager.pooling.ObjectReturn(2);
            Debug.Log(_bullet);
            if(_bullet == null)
            {
                BulletSpawn();  
            }else{

                _bullet.transform.position = gunBarrel.position;
                _bullet.SetActive(true);
                Rigidbody _rb = _bullet.GetComponent<Rigidbody>();
                _rb.AddForce(gunBarrel.transform.forward * bulletSpeed);
            }

        }
        GameObject BulletSpawn()
        {
            GameManager.instance.spawnManager.BulletSpawn(100);
            GameObject _object =GameManager.instance.poolManager.pooling.ObjectReturn(2);
            return _object;
            
        }
    }

}

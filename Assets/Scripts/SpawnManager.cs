using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Main.Spawn
{

    public class SpawnManager : MonoBehaviour
    {
        public SpawnObject spawnObject;
        GameManager gameManager;
        [SerializeField]GameObject coin;
        [SerializeField]GameObject parentCoin;
        [SerializeField]List<GameObject> zombie;
        [SerializeField]GameObject parentZombie;
        PoolScriptableObject poolScriptableObject;

        [SerializeField]GameObject bullet;
        [SerializeField]GameObject parentBullet;
        void Start()
        {
            poolScriptableObject = GameManager.instance.poolManager.poolScriptableObject;
            
            BulletSpawn(100);
            ZombieSpawn(10);
            CoinSpawn(100);
        }

        void ObjectSpawn(GameObject _object ,List<GameObject> _list ,GameObject _parentObject, int _size)
        {
            spawnObject.Spawn(_object,_list,_parentObject,_size);
        }

        public void BulletSpawn(int _size)
        {
            ObjectSpawn(bullet,poolScriptableObject.Bullet,parentBullet,_size);
        }
        public void ZombieSpawn(int _size)
        {
            
            ObjectSpawn(zombie[0],poolScriptableObject.Zombie,parentZombie,_size);
            ObjectSpawn(zombie[1],poolScriptableObject.Zombie,parentZombie,_size);
            ObjectSpawn(zombie[2],poolScriptableObject.Zombie,parentZombie,_size);
            ObjectSpawn(zombie[3],poolScriptableObject.Zombie,parentZombie,_size);
        }

        public void CoinSpawn(int _size)
        {
            ObjectSpawn(coin,poolScriptableObject.Coins,parentCoin,_size);
        }


        
        


        
        
    }
}

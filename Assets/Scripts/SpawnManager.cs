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
            ObjectSpawn(coin,poolScriptableObject.Coins,parentCoin,15);
            ObjectSpawn(zombie[0],poolScriptableObject.Zombie,parentZombie,10);
            ObjectSpawn(zombie[1],poolScriptableObject.Zombie,parentZombie,10);
            ObjectSpawn(zombie[2],poolScriptableObject.Zombie,parentZombie,10);
            ObjectSpawn(zombie[3],poolScriptableObject.Zombie,parentZombie,10);
            ObjectSpawn(bullet,poolScriptableObject.Bullet,parentBullet,100);
        }

        void ObjectSpawn(GameObject _object ,List<GameObject> _list ,GameObject _parentObject, int _size)
        {
            spawnObject.Spawn(_object,_list,_parentObject,_size);
        }
        


        
        
    }
}

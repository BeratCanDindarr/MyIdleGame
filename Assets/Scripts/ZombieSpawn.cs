using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main.Zombie
{

    public class ZombieSpawn : MonoBehaviour
    {
        public float timer;
        float _timer;
        GameManager gameManager;
        // Start is called before the first frame update
        void Start()
        {
            gameManager = GameManager.instance;
           _timer = timer;
        }

        // Update is called once per frame
        void Update()
        {
            _timer = gameManager.Timer(_timer);
            if(_timer< 0)
            {
                SpawnCoin();
                _timer = timer;

            }
        }
        void SpawnCoin()
            {
                int xPosition = Random.Range(-9,9);
                //GameObject _coin = Instantiate(coin);
                GameObject _coin = gameManager.poolManager.pooling.ObjectReturn(1);
                _coin.SetActive(true);
                _coin.transform.position = new Vector3(xPosition,gameObject.transform.position.y,gameObject.transform.position.z);
                
            }
    }
}

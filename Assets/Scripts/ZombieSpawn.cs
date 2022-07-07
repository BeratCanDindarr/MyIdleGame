using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main.Zombie
{

    public class ZombieSpawn : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(1))
            {
                SpawnCoin();
            }
        }
        void SpawnCoin()
            {
                //GameObject _coin = Instantiate(coin);
                GameObject _coin = GameManager.instance.poolManager.pooling.ObjectReturn(1);
                _coin.SetActive(true);
                _coin.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z);
                
            }
    }
}

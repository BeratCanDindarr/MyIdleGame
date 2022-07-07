
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

namespace Main.Animation
{

    public class MoneyTransformAnimation : MonoBehaviour
    {
        public GameObject coin;
        [SerializeField]GameObject targetObject;
        
        public Transform playerTrans;
        public PathType pathSystem = PathType.CatmullRom;
        public Vector3[] pathval = new Vector3[2];
        public float timer;
        float _timer;
        bool coinSpawn = false;
        [SerializeField]int structurePrice;
        public TextStructureChange structureScripts;
        public GameObject textCanvas;
        GameManager gameManager;
        
        // Start is called before the first frame update
        void Start()
        {
            gameManager = GameManager.instance;
            pathval[0] = pathAdd(pathval[0]);
            pathval[1] = new Vector3(targetObject.transform.position.x,targetObject.transform.position.y,targetObject.transform.position.z);
            _timer = timer;
            
        }
        void Update()
        {
           Timer();
        }
        void Timer()
        {
             _timer = gameManager.Timer(_timer);
            
            if(_timer <= 0)
            {
                coinSpawn = true;
                _timer = timer;
            }
        }

        
        void OnTriggerStay(Collider other)
        {
            
            if(coinSpawn == true && structurePrice > 0)
            {
                if(other.tag == "Player" )
                {
                    var _coin = SpawnCoin();
                    _coin.transform.DOPath(pathval,4,pathSystem);
                    coinSpawn = false;
                    structurePrice--;
                    structureScripts.StructurePrice(structurePrice);
                    if(structurePrice<=0)
                    {
                        CreateStructured();
                    }
                }
            }
        }
        void CreateStructured()
        {
            textCanvas.SetActive(false);
            targetObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }

        
        GameObject SpawnCoin()
        {
            //GameObject _coin = Instantiate(coin);
            GameObject _coin = GameManager.instance.poolManager.pooling.ObjectReturn(0);
            _coin.SetActive(true);
            _coin.transform.position = new Vector3(playerTrans.transform.position.x,1.77f,playerTrans.transform.position.z);
            return _coin;
        }

        
        Vector3 pathAdd(Vector3 _pathval)
        {
            var _position = targetObject.GetComponent<Transform>().position;
            if(_position.x < 0)
            {
                if(_position.z < 0)
                {
                    _pathval = new Vector3((_position.x - transform.position.x)/2,3,(_position.z-transform.position.z)/2);
                    
                }
                else
                {
                    _pathval = new Vector3((_position.x + transform.position.x)/2,3,(_position.z+transform.position.z)/2);
                }
            }
            else
            {
                _pathval = new Vector3((_position.x + transform.position.x)/2,3,(_position.z+transform.position.z)/2);
            }
            return _pathval;
        }
    }
}

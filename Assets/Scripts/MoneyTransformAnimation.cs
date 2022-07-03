
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoneyTransformAnimation : MonoBehaviour
{
    public GameObject coin;
    [SerializeField]Transform targetObject;
    public Transform playerTrans;
    public PathType pathSystem = PathType.CatmullRom;
    public Vector3[] pathval = new Vector3[2];
    public float timer;
    float _timer;
    bool coinSpawn = false;
    // Start is called before the first frame update
    void Start()
    {
        pathval[0] = pathAdd(pathval[0]);
        pathval[1] = new Vector3(targetObject.transform.position.x,targetObject.transform.position.y,targetObject.transform.position.z);
        _timer = timer;
    }
    void Update()
    {
        _timer -= Time.deltaTime;
        Debug.Log(_timer);
        if(_timer <= 0)
        {
            coinSpawn = true;
            _timer = timer;
        }
    }

    
    void OnTriggerStay(Collider other)
    {
        
        if(coinSpawn == true)
        {
            if(other.tag == "Player" )
            {
                var _coin = SpawnCoin();
                _coin.transform.DOPath(pathval,4,pathSystem);
                coinSpawn = false;
            }
        }
    }

    
    GameObject SpawnCoin()
    {
        //GameObject _coin = Instantiate(coin);
        GameObject _coin = PoolManager.instance.pooling.ObjectReturn(0);
        _coin.SetActive(true);
        _coin.transform.position = new Vector3(playerTrans.transform.position.x,1.77f,playerTrans.transform.position.z);
        return _coin;
    }

    
    Vector3 pathAdd(Vector3 _pathval)
    {
        var _position = targetObject.position;
        if(_position.x < 0)
        {
            if(_position.z < 0)
            {
                _pathval = new Vector3((_position.x - transform.position.x)/2,3,(_position.z-transform.position.z)/2);
                
            }
            else
            {
                _pathval = new Vector3((_position.x - transform.position.x)/2,3,(_position.z+transform.position.z)/2);
            }
        }
        else
        {
            _pathval = new Vector3((_position.x + transform.position.x)/2,3,(_position.z+transform.position.z)/2);
        }
        return _pathval;
    }
}

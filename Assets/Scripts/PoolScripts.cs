using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main.Pool
{

    public class PoolScripts : MonoBehaviour
    {
        [SerializeField]GameObject coin;
        PoolManager poolManager;
        
        void Start()
        {
            poolManager = GameManager.instance.poolManager;
           
        }

        // Update is called once per frame
        void Update()
        {
            
        }
      
        public GameObject ObjectReturn(int _itemCode)
        {
            GameObject _returnObject = null;
            switch(_itemCode)
            {
                case 0:
                    //coin
                    
                    _returnObject = CheckAndReturn(poolManager.poolScriptableObject.Coins);
                    break;
                case 1:
                    //zombie
                    _returnObject = CheckAndReturn(poolManager.poolScriptableObject.Zombie);
                    break;
                case 2:
                    //zombie
                    _returnObject = CheckAndReturn(poolManager.poolScriptableObject.Bullet);
                    break;
            }
            
            return _returnObject;
        }
        GameObject CheckAndReturn(List<GameObject> _object)
        {
            GameObject _returnObject = null;
            for(int i =0;i<=_object.Count;i++)
            {
                if(!_object[i].active)
                {
                    _returnObject = _object[i];
                    _object.RemoveAt(i);
                    
                    break;
                }
                
            }
            return _returnObject;
        }

        
        
    }
}

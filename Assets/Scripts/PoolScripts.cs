using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main.Pool
{

    public class PoolScripts : MonoBehaviour
    {
        [SerializeField]GameObject coin;
        PoolManager poolManager;
        GameObject deneme;
        void Start()
        {
            poolManager = GameManager.instance.poolManager;
            Spawn(coin,15);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void Spawn(GameObject _object , int _size)
        {
            for(int i = 0; i<= _size ; i++)
            {
                var _item = Instantiate(_object,this.gameObject.transform);
                _item.transform.position = transform.position;
                poolManager.poolScriptableObject.Coins.Add(_item);
                _item.SetActive(false);

            }

        }
        public GameObject ObjectReturn(int _itemCode)
        {
            
            switch(_itemCode)
            {
                case 0:
                    //coin
                    
                    CheckAndReturn(poolManager.poolScriptableObject.Coins);
                    break;
                case 1:
                    //zombie
                    CheckAndReturn(poolManager.poolScriptableObject.Zombie);
                    break;
            }
            
            return deneme;
        }
        void CheckAndReturn(List<GameObject> _object)
        {
            
            for(int i =0;i<=_object.Count;i++)
            {
                if(!_object[i].active)
                {
                    deneme = _object[i];
                    _object.RemoveAt(i);
                    
                    break;
                }
                else
                    deneme = null;
            }
        
        }

        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main;

namespace Main.Spawn
{

    public class SpawnObject : MonoBehaviour
    {
        
    
        public void Spawn(GameObject _object ,List<GameObject> _list ,GameObject _parentObject, int _size)
            {
                for(int i = 0; i<= _size ; i++)
                {
                    var _item = Instantiate(_object,_parentObject.transform);
                    _item.transform.position = transform.position;
                    _list.Add(_item);
                    _item.SetActive(false);

                }

            }
    }
}


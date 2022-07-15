using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Shoot;
namespace Main.Ai.Defender
{
    public class DefenderScript : MonoBehaviour
    {
        public List<GameObject> target;
        Aiming aim;
        
        // Start is called before the first frame update
        void Start()
        {
            aim = GameManager.instance.shootManager.aimingScript;
        }

        // Update is called once per frame
        void Update()
        {
            if(target.Count != 0)
            {
                aim.Aim(gameObject,target[0].transform.position);
            }
        }

        public void targetAdd(GameObject _target)
        {
            target.Add(_target);
        }
    }

}

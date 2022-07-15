using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Shoot;
namespace Main.Ai.Defender
{
    public class DefenderScript : MonoBehaviour
    {
        public List<GameObject> target;
        public GameObject gunBarrel;
        Aiming aim;
        Shooting shot;

        
        
        // Start is called before the first frame update
        void Start()
        {
            aim = GameManager.instance.shootManager.aimingScript;
            shot = GameManager.instance.shootManager.shootingScript;
        }

        // Update is called once per frame
        void Update()
        {
            if(target.Count != 0)
            {
                aim.Aim(gameObject,target[0].transform.position);
            }
            if(Input.GetMouseButtonDown(0))
            {
                
                GameManager.instance.shootManager.shootingScript.Shot(gunBarrel.transform);
                
            }
        }

        public void targetAdd(GameObject _target)
        {
            target.Add(_target);
        }

    }

}

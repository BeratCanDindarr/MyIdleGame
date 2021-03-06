using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Shoot;
namespace Main.Ai.Defender
{
    public class DefenderScript : MonoBehaviour
    {
        
        public GameObject gunBarrel;
        GameManager gameManager;
        Aiming aim;
        ShootManager shot;

        bool listEmpty = false;
        public float timer;
        float _timer;

        AIManager aIManager;
        
       
        // Start is called before the first frame update
        void Start()
        {
            _timer = timer;
            gameManager = GameManager.instance;
            aim = gameManager.shootManager.aimingScript;
            shot = gameManager.shootManager;
            aIManager = gameManager.aIManager;
        }

        // Update is called once per frame
        void Update()
        {
            if(aIManager.target.Count != 0)
            {
                aim.Aim(gameObject,aIManager.target[0].transform.position);
                listEmpty = true;
            }
            if(listEmpty && _timer<=0)
            {
                
                _timer = timer;
                Shoot();
                
            }
            Timer();
        }

        void Shoot()
        {
            shot.shootingScript.Shot(gunBarrel.transform);
        }
        void Timer()
        {
            _timer = gameManager.Timer(_timer);
            
        }

        public void targetAdd(GameObject _target)
        {
            aIManager.target.Add(_target);
        }
        public void DeleteTarget(GameObject _target)
        {
            aIManager.target.Remove(_target);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main.Shoot
{
    public class ShootManager : MonoBehaviour
    {
        public Shooting shootingScript;
        public Aiming aimingScript;
        public PoolScriptableObject pool;
        // Start is called before the first frame update
        void Start()
        {
            pool = GameManager.instance.poolManager.poolScriptableObject;
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

}

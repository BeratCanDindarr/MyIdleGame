using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Player;
using Main.Pool;
using Main.Ai;
using Main.Spawn;
using Main.Shoot;

namespace Main
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public PlayerManager playerManager;
        public PoolManager poolManager;
        
        public SpawnManager spawnManager;
        public AIManager aIManager;
        public ShootManager shootManager;
        public GameObject player;


        public Vector3 defaultPosition;
        
        // Start is called before the first frame update
        void Awake()
        {
            instance = this;
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public float Timer(float _timer)
        {
            _timer -= Time.deltaTime;
            return _timer;
        }
        
       
    }

}

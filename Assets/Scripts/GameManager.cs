using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Player;
using Main.Pool;

using Main.Spawn;
using Main.AI;
namespace Main
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public PlayerManager playerManager;
        public PoolManager poolManager;
        
        public SpawnManager spawnManager;
        public AIManager aIManager;
        
        // Start is called before the first frame update
        void Awake()
        {
            instance = this;
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        
    }

}

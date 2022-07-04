using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Player;
using Main.Pool;

namespace Main
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public PlayerManager playerManager;
        public PoolManager poolManager;
        
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

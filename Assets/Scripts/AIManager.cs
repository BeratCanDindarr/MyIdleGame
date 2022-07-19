using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main.Ai.Zombie;
using Main.Ai.Defender;
namespace Main.Ai
{
    public class AIManager : MonoBehaviour
    {
        public Transform targetObject;
        public ZombieSpawn zombieSpawn;

        public DefenderScript defenderScript;
        public List<GameObject> target;
        
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
       
    }
}
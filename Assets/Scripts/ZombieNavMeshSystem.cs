using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Main.Ai.Zombie
{
    public class ZombieNavMeshSystem : MonoBehaviour , IRangeAble
    {
       public Transform target;
        NavMeshAgent zombieNavMeshAgent;
        public float zombieSpeed;
        GameManager gameManager;

        // Start is called before the first frame update
        void Start()
        {
            gameManager = GameManager.instance;
            target = gameManager.aIManager.targetObject;
                zombieNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
                zombieNavMeshAgent.speed = zombieSpeed;
        }
       

        // Update is called once per frame
        void FixedUpdate()
        {
             zombieNavMeshAgent.destination = target.position;   
        }

        public void RangeAdd()
        {
            gameManager.aIManager.defenderScript.targetAdd(gameObject);
        }

        
    }
}
    

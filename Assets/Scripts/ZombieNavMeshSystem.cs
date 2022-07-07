using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Main.Zombie
{
    public class ZombieNavMeshSystem : MonoBehaviour
    {
        Transform target;
        NavMeshAgent zombieNavMeshAgent;
        public float zombieSpeed;

        // Start is called before the first frame update
        void Start()
        {
            target = GameManager.instance.aIManager.targetObject.transform;
                zombieNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
                zombieNavMeshAgent.speed = zombieSpeed;
        }
       

        // Update is called once per frame
        void FixedUpdate()
        {
         zombieNavMeshAgent.destination = target.position;   
        }
    }
}
    

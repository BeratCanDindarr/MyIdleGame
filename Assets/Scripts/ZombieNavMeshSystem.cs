using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Main.Ai.Zombie
{
    public class ZombieNavMeshSystem : MonoBehaviour , IRangeAble , IDamageAble<float>
    {
       public Transform target;
        NavMeshAgent zombieNavMeshAgent;
        public float zombieSpeed;
        GameManager gameManager;
        public float health;

        // Start is called before the first frame update
        void Start()
        {
            gameManager = GameManager.instance;
            target = gameManager.aIManager.targetObject;
                zombieNavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
                zombieNavMeshAgent.speed = zombieSpeed;
        }
       void Update()
       {
           if(health<=0)
           {
             gameManager.aIManager.defenderScript.DeleteTarget(gameObject);
             gameObject.SetActive(false);
           }
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
        public void Damage(float _damage)
        {
            health -=_damage;
        }

        
    }
}
    

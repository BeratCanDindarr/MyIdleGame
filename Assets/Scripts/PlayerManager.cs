using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main.Player
{
    public class PlayerManager : MonoBehaviour
    {
        
        public PlayerMovement playerMovement;
        public Joystick joystick;

        // Start is called before the first frame update
        void Awake()
        {
              
        }
        void Update()
        {
            
            playerMovement.MovePlayer();
        }

        
    }

}

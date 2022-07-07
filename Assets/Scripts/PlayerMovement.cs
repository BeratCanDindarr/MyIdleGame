

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Main.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        public GameObject player;
        [SerializeField]Joystick gameJoystick;
        float horizontalMove;
        float verticalMove;
        [SerializeField] float moveSpeed;
        [SerializeField] float rotationSpeed;
        public Animator playerAnimation;

        // Start is called before the first frame update
        void Start()
        {
            Joystick joystick = Main.GameManager.instance.playerManager.joystick;
            gameJoystick = joystick;
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void MovePlayer()
        {
                
                horizontalMove = gameJoystick.Horizontal ;
                verticalMove = gameJoystick.Vertical ;
            if(horizontalMove !=0 && verticalMove !=0)
            {
                playerAnimation.Play("Walk");
                Vector3 _move = new Vector3(horizontalMove,0f,verticalMove);
                _move.Normalize();

                transform.Translate(_move* moveSpeed * Time.deltaTime,Space.World);
                if(_move != Vector3.zero)
                {
                    
                    Quaternion toRotation = Quaternion.LookRotation(_move,Vector3.up);  

                    player.transform.rotation = Quaternion.RotateTowards(player.transform.rotation,toRotation,rotationSpeed*Time.deltaTime);
                }
            
            }
            else
            {
                playerAnimation.Play("idle");
            }

        }
    }

}

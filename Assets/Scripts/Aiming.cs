using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main.Shoot
{
    public class Aiming : MonoBehaviour
    {
        
        public void Aim(GameObject _player,Vector3 _target)
        {
            _player.transform.LookAt(_target);
        }
    }

}

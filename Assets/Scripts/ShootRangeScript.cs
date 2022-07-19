using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRangeScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        var range =other.gameObject.GetComponent<IRangeAble>();
        if(range != null)
        {
            range.RangeAdd();
        }
    }
}

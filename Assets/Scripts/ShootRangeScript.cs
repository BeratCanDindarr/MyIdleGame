using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRangeScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<IRangeAble>().RangeAdd();
    }
}

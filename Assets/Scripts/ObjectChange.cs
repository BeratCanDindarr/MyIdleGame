using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChange : MonoBehaviour
{
    public GameObject _object;


    public void objectOpen()
    {
        _object.SetActive(true);
    }
}

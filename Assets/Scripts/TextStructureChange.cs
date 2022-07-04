using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextStructureChange : MonoBehaviour
{
    TextMeshProUGUI structureText;
    // Start is called before the first frame update
    void Start()
    {
        structureText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StructurePrice(int i)
    {
        structureText.text = i.ToString();
    }
}

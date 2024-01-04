using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
        }
    }
}

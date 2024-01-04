using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickableViewable : MonoBehaviour
{

    public GameObject viewableSprite;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("clicked");
            viewableSprite.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public string nameOfObject;
    public GameObject acquiredTextRef;

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
            if(gameObject.tag.Equals("pickup"))
            {
                acquiredTextRef.GetComponent<FadeAway>().objAcquired = nameOfObject;
                acquiredTextRef.SetActive(true);
            }
        }
    }
}

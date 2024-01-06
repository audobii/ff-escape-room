using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickableObject : MonoBehaviour
{
    public string nameOfObject;
    public GameObject acquiredTextRef;
    public GameObject canvasRef;

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Debug.Log("clicked");
            if(gameObject.tag.Equals("pickup"))
            {
                /*
                acquiredTextRef.GetComponent<FadeAway>().objAcquired = nameOfObject;
                acquiredTextRef.SetActive(true);
                */

                Debug.Log("picked up");

                /*
                GameObject newTxt = Instantiate(canvasRef);
                newTxt.transform.GetChild(0).gameObject.GetComponent<FadeAway>().objAcquired = nameOfObject;
                newTxt.SetActive(true);
                */

                GameObject newTxt = Instantiate(acquiredTextRef, canvasRef.transform);
                newTxt.GetComponent<FadeAway>().objAcquired = nameOfObject;
                newTxt.SetActive(true);
            }
        }
    }
}

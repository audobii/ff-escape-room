using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FadeAway : MonoBehaviour
{
    public int delay;
    public string objAcquired = "something";

    bool done = false;
    float fade;
    int fadeSpeed = 5;
    Color newColor;
    Color currColor;

    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Acquired " + objAcquired + ".";
        StartCoroutine(Delay());
    }

    void Update()
    {
        if(done)
        {
            currColor = gameObject.GetComponent<TextMeshProUGUI>().color;
            fade = currColor.a - (Time.deltaTime*fadeSpeed);
            newColor = new Color(currColor.r, currColor.g, currColor.b, fade);

            gameObject.GetComponent<TextMeshProUGUI>().color = newColor;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        done = true;
    }
}

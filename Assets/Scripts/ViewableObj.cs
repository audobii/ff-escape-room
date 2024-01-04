using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewableObj : MonoBehaviour
{
    public GameObject playerRef;

    private void Awake()
    {
        playerRef.GetComponent<PlayerMovement>().canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRef.GetComponent<PlayerMovement>().canMove = true;
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //code from of https://www.youtube.com/watch?v=uFbQalvs6ao

    public Transform _camera;
    public float speed, rotSpeed;
    private float rotX, rotY;
    private Rigidbody rb;
    private Vector3 offset;
    private Vector3 moveDelta;

    private void Awake()
    {
        offset = _camera.position - transform.position; 
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        //force cursor invisible + set to middle
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Rotate();
        Move();
    }

    void Rotate()
    {
        rotY += Input.GetAxisRaw("Mouse X") * rotSpeed * Time.deltaTime;
        rotX -= Input.GetAxisRaw("Mouse Y") * rotSpeed * Time.deltaTime;

        //clamp x rotation so you dont overrotate and see player's body
        rotX = Mathf.Clamp(rotX, -90f, 53f);

        transform.rotation = Quaternion.Euler(0f, rotY, 0f); //rotate along y axis to make it look to the sides
        _camera.rotation = Quaternion.Euler(rotX, rotY, 0f);
    }

    void Move()
    {
        _camera.position = transform.position + offset;

        moveDelta = transform.forward * Input.GetAxisRaw("Vertical") + transform.right * Input.GetAxisRaw("Horizontal");
        rb.velocity = moveDelta.normalized * speed;

    }
}

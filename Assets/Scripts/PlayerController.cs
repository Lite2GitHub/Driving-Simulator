using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horiInput; // Horizontal
    private float vertInput; // Vertical


    void Start()
    {
        
    }

    void Update()
    {
        // Turning
        horiInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");

        // Moves the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertInput);

        // Turns/rotates the vehicle.
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horiInput);

    }
}

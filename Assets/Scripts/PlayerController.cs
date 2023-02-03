using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;
    public float TurnSpeed = 15;
    public float HorizontalInput;
    public float ForwardInput;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * ForwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * HorizontalInput);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3 (horizontal * speed*Time.deltaTime,rigidbody.velocity.y,vertical*speed*Time.deltaTime);
        float xPos = Mathf.Clamp(transform.position.x, -9f, 9f);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}

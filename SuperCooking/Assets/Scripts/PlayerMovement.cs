using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{


    public float speed = 5;
    public float gravity = -9.81f;
    CharacterController cc;
    public float x;
    public float z;
    public float y;

    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {



        Vector3 move = transform.right * x + transform.forward * z;
        
        cc.Move( move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        cc.Move(velocity * Time.deltaTime);

    }

    public void OnMove(InputValue value)
    {
        x = value.Get<Vector2>().x;
        z = value.Get<Vector2>().y;
    }
    

}
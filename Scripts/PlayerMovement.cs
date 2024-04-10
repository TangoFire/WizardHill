using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerMovement : MonoBehaviour
{

    float _speed = 10f;

    Rigidbody2D _rb;

    Vector2 _playerInput;



     void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
     private void Update()
    {
       // input.x = Input.GetAxisRaw("Horizontal");
       // input.y = Input.GetAxisRaw("Vertical");

        _playerInput = new Vector2(Input.GetAxisRaw("Horizontal") * _speed, Input.GetAxisRaw("Vertical") * _speed);

    }
    void FixedUpdate()
    {
        // Vector2 direction = input.normalized;
        //  Vector2 velocity = direction * moveSpeed;
        //  Vector2 movement = velocity * Time.fixedDeltaTime;

        //  rb.MovePosition((Vector2)transform.position + movement);

        _rb.AddForce(_playerInput);


    }

}
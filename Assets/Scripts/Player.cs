using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float torqueAmount = 5f;
    SurfaceEffector2D effector;

    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f ;

    bool canMove = true;
    
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        effector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableController()
    {
        canMove = false;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddTorque(-torqueAmount);
        }
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            effector.speed = boostSpeed;
        }
        else
        {
            effector.speed = baseSpeed;
        }
    }
}

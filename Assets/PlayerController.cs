using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isPlayer1;
    public float speed = 10;
    public bool isGrounded;
    public float jumpSpeed = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer1)
        {
            Player1Movement();
        }
        else
        {
            Player2Movement();
        }
        
    }
    void Player1Movement()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            this.transform.Translate(-h, 0, 0);

        }
        if (Input.GetAxis("Vertical") != 0)
        {
            float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            this.transform.Translate(0, 0, -v);
        }

        if (isGrounded)
        {
        if (Input.GetAxis("Jump") > 0)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * jumpSpeed);
            isGrounded = false;
        }
        }

    }
    void Player2Movement()
    {
        if (Input.GetAxis("Horizontal2") != 0)
        {
            float h = Input.GetAxis("Horizontal2") * speed * Time.deltaTime;
            this.transform.Translate(-h, 0, 0);

        }
        if (Input.GetAxis("Vertical2") != 0)
        {
            float v = Input.GetAxis("Vertical2") * speed * Time.deltaTime;
            this.transform.Translate(0, 0, -v);
        }

        if (isGrounded)
        {
        if (Input.GetAxis("Jump2") > 0)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0) * jumpSpeed);
            isGrounded = false;
        }
        }

    }

    void OnCollisionEnter(Collision other)
    {
            isGrounded = true;
    }
}

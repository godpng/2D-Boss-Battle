using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float jumpPower;
    private bool isGrounded;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);
        RaycastHit2D hit2 = Physics2D.Raycast(new Vector2(transform.position.x - 1.0f, transform.position.y), Vector2.down);
        RaycastHit2D hit3 = Physics2D.Raycast(new Vector2(transform.position.x + 1.0f, transform.position.y), Vector2.down);

        Debug.DrawRay(transform.position, Vector2.down * 2.0f, Color.red);
        Debug.DrawRay(new Vector2(transform.position.x - 1.0f, transform.position.y), Vector2.down * 2.0f, Color.red);
        Debug.DrawRay(new Vector2(transform.position.x + 1.0f, transform.position.y), Vector2.down * 2.0f, Color.red);*/

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPower));
            isGrounded = false;
        }

        if (Input.GetKey("d")) 
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-Speed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKeyUp("d") || Input.GetKeyUp("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{

    public Rigidbody2D rb;
    public float move_direction;
    int speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 200;
        move_direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown("up") || Input.GetKeyDown("down") || Input.GetKeyDown("left") || Input.GetKeyDown("right")) {
            
            rb.velocity = new Vector2(move_direction * 450 * Time.fixedDeltaTime, rb.velocity.y);
        }*/

        /*if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d")) {

            rb.velocity = new Vector2(move_direction * 450 * Time.fixedDeltaTime, rb.velocity.x);
        }*/

        // Get Player Movement Input
        move_direction = (Input.GetAxisRaw("Horizontal")); 

        if (Input.GetKeyDown("right") || Input.GetKeyDown("d")) {
            
            rb.velocity = new Vector2(move_direction * speed * Time.fixedDeltaTime, rb.velocity.y);
        }

        if (Input.GetKeyDown("left") || Input.GetKeyDown("a")) {

            rb.velocity = new Vector2(move_direction * speed * Time.fixedDeltaTime, rb.velocity.x);
        }

    }
}

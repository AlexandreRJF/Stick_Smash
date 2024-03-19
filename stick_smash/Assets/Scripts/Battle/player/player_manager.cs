using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{

    public Rigidbody2D rb;
    public float move_direction;
    int vitesse;
    int force_saut;

    // Start is called before the first frame update
    void Start()
    {
        vitesse = 200;
        force_saut = 8;
        move_direction = 1;
    }

    // Update is called once per frame
    void Update()
    {

        // Get Player Movement Input
        move_direction = (Input.GetAxisRaw("Horizontal")); 

        if (Input.GetKeyDown("right") || Input.GetKeyDown("d")) {
            
            rb.velocity = new Vector2(move_direction * vitesse * Time.fixedDeltaTime, rb.velocity.y);
        }

        if (Input.GetKeyDown("left") || Input.GetKeyDown("a")) {

            rb.velocity = new Vector2(move_direction * vitesse * Time.fixedDeltaTime, rb.velocity.x);
        }

        if (Input.GetKeyDown("space") || Input.GetKeyDown("[0]")) {

            jump();
        }
    }


    // Permet de sauter
    void jump() {

        rb.velocity = Vector2.up * force_saut;
    }
}

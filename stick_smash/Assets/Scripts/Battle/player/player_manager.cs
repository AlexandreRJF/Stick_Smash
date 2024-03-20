using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{

    public Rigidbody2D rb;
    public float move_direction;
    int vitesse;
    int force_saut;
    bool is_on_ground;

    // Start is called before the first frame update
    void Start()
    {
        vitesse = 200;
        force_saut = 8;
        move_direction = 1;
        is_on_ground = false;
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

            verif_jump();
        }
    }


    // Permet de vérifier que le joueur peut sauter
    void verif_jump() {

        if (is_on_ground == true) {
            
            jump();
        }

        else {
            Debug.Log("is_on_ground est false");
        }
    }


    // Permet de sauter
    void jump() {

        rb.velocity = Vector2.up * force_saut;
    }


    // Permet de détecter quand le perso arrive au sol
    void OnCollisionEnter2D(Collision2D hit_box) {
        
        is_on_ground = true;
    }


    // Permet de détecter quand le perso quitte le sol
    void OnCollisionExit2D(Collision2D hit_box) {
        
        is_on_ground = false;
    }
}

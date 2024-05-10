using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_manager : MonoBehaviour
{

    // Component
    public Rigidbody2D rb;

    // Bool
    bool is_on_ground;

    // Scripts
    [SerializeField] player_controller Player_Controller;

    // Start is called before the first frame update
    void Start()
    {
        is_on_ground = false;
    }


    // Permet de vérifier que le joueur peut sauter
    public void verif_jump() {

        if (is_on_ground == true) {
            
            jump();
        }
    }


    // Permet de sauter
    void jump() {

        //rb.velocity = Vector2.up * force_saut;
        rb.velocity = new Vector2(rb.velocity.x, Player_Controller.force_saut);
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

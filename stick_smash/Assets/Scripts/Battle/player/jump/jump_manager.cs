using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_manager : MonoBehaviour
{

    // Component
    public Rigidbody2D rb;

    // Bool
    bool is_on_ground;

    // Int
    int nombre_sauts;

    // Scripts
    [SerializeField] player_controller Player_Controller;

    // Start is called before the first frame update
    void Start()
    {
        is_on_ground = false;
        nombre_sauts = 0;
    }


    // Permet de vérifier que le joueur peut sauter
    public void verif_jump() {
        
        if (nombre_sauts > 0) {
            
            jump();
            reduction_nombre_sauts();
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
        set_nombre_sauts();
    }


    // Permet de détecter quand le perso quitte le sol
    void OnCollisionExit2D(Collision2D hit_box) {

        is_on_ground = false;
    }

    // Permet de réduire les sauts restants au joueur
    void reduction_nombre_sauts() {

        nombre_sauts -= 1;
    }


    // Permet de set le nombre de sauts restants
    void set_nombre_sauts() {

        nombre_sauts = 2;
    }
}

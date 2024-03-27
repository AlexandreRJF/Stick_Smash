using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{

    public Rigidbody2D rb;
    public float move_direction;
    int vitesse;
    int force_saut;
    bool is_on_ground;
    direction direction_looking;


    // Start is called before the first frame update
    void Start()
    {
        vitesse = 200;
        force_saut = 8;
        move_direction = 1;
        is_on_ground = false;
        direction_looking = direction.droite;
    }


    // Permet de vérifier que le joueur peut sauter
    public void verif_jump() {

        if (is_on_ground == true) {
            
            jump();
        }

        else {
            Debug.Log("is_on_ground est false");
        }
    }


    // Permet de sauter
    public void jump() {

        rb.velocity = Vector2.up * force_saut;
    }


    // Permet de vérifier que le joueur peut bouger
    public void verif_rotation(direction gauche_droite) {

        switch (gauche_droite) {

            case direction.gauche:
                
                if (direction_looking == direction.droite) {
                    Debug.Log("faut changer de rota");
                    transform.rotation = Quaternion.Euler(0,-180,0);
                }

                else {
                    Debug.Log("c'est good");
                }

            break;

            case direction.droite:
            
                if (direction_looking == direction.gauche) {
                    Debug.Log("faut changer de rota");
                    transform.rotation = Quaternion.Euler(0,0,0);
                }

                else {
                    Debug.Log("c'est good");
                }

            break;
        }
    }    


    // Permet de donner une impulsion vers la droite au Rigid Body du joueur
    public void move_right() {

        rb.velocity = new Vector2(move_direction * vitesse * Time.fixedDeltaTime, rb.velocity.y);
        direction_looking = direction.droite;
    }


    // Permet de donner une impulsion vers la gauche au Rigid Body du joueur
    public void move_left() {

        rb.velocity = new Vector2(move_direction * vitesse * Time.fixedDeltaTime, rb.velocity.x);
        direction_looking = direction.gauche;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject cube_1;
    public GameObject cube_2;
    public float move_direction;
    int vitesse;
    int force_saut;
    bool is_on_ground;
    direction direction_looking;

    public enum direction {
        gauche, droite
    };


    // Start is called before the first frame update
    void Start()
    {
        vitesse = 200;
        force_saut = 8;
        move_direction = 1;
        is_on_ground = false;
        direction_looking = direction.droite;
    }

    // Update is called once per frame
    void Update()
    {

        // Get Player Movement Input
        move_direction = (Input.GetAxisRaw("Horizontal"));

        if (Input.GetKeyDown("right") || Input.GetKeyDown("d")) {
            verif_rotation(direction.droite);
            move_right();
        }

        if (Input.GetKeyDown("left") || Input.GetKeyDown("a")) {            
            verif_rotation(direction.gauche);
            move_left();
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


    // Permet de vérifier que le joueur peut bouger
    void verif_rotation(direction gauche_droite) {

        switch (gauche_droite) {

            case direction.gauche:
                
                if (direction_looking == direction.droite) {
                    Debug.Log("faut changer de rota");
                    cube_1.transform.rotation = Quaternion.Euler(0,-180,0);
                    cube_2.transform.rotation = Quaternion.Euler(0,-180,0);
                }

                else {
                    Debug.Log("c'est good");
                }

            break;

            case direction.droite:
            
                if (direction_looking == direction.gauche) {
                    Debug.Log("faut changer de rota");
                    cube_1.transform.rotation = Quaternion.Euler(0,0,0);
                    cube_2.transform.rotation = Quaternion.Euler(0,0,0);
                }

                else {
                    Debug.Log("c'est good");
                }

            break;
        }
    }    


    // Permet de donner une impulsion vers la droite au Rigid Body du joueur
    void move_right() {

        rb.velocity = new Vector2(move_direction * vitesse * Time.fixedDeltaTime, rb.velocity.y);
        direction_looking = direction.droite;
    }


    // Permet de donner une impulsion vers la gauche au Rigid Body du joueur
    void move_left() {

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{

    // Float
    public float move_direction;
    public float horizontal_axis_J1 = 0; // Axe du joueur 1
    public float horizontal_axis_J2 = 0; // Axe du joueur 2

    // Direction
    direction direction_looking;

    // Scripts
    [SerializeField] player_controller J1;
    [SerializeField] player_controller J2;


    // Update is called once per frame
    void Update()
    {

        // Get Player Movement Input
        move_direction = Input.GetAxisRaw("Horizontal");

        horizontal_axis_J1 = get_horizontal_J1(); // Récupére l'axe Horizontal du joueur 1
        horizontal_axis_J2 = get_horizontal_J2(); // Récupére l'axe Horizontal du joueur 1

        J1.horizontal_axis = horizontal_axis_J1;
        J2.horizontal_axis = horizontal_axis_J2;

        verif_input_j1();
        verif_input_j2();
    }


    // Permet de vérifier si le J1 à appuyer sur des touches
    void verif_input_j1() {

        if (Input.GetKey("d")) {
            J1.verif_rotation(direction.droite);
            J1.verif_move_player(direction.droite);
        }

        else if (Input.GetKey("a")) {            
            J1.verif_rotation(direction.gauche);
            J1.verif_move_player(direction.gauche);
        }

        if (Input.GetKeyDown("space") || Input.GetKeyDown("w")) {

            J1.player_jump();
        }

        if (Input.GetKey("s")) {

            J1.player_attack();
        }
    }


    // Permet de vérifier si le J2 à appuyer sur des touches
    void verif_input_j2() {

        if (Input.GetKey("right")) {
            J2.verif_rotation(direction.droite);
            J2.verif_move_player(direction.droite);
        }

        else if (Input.GetKey("left")) {            
            J2.verif_rotation(direction.gauche);
            J2.verif_move_player(direction.gauche);
        }

        if (Input.GetKeyDown("[0]") || Input.GetKeyDown("up")) {

            J2.player_jump();
        }

        if (Input.GetKey("down")) {

            J2.player_attack();
        }
    }


    // Permet de récupérer l'axe horizontale du J1
    float get_horizontal_J1() {
        float right = Input.GetKey("d") ? 1 : 0; // Si le joueur appuie sur D (Qwerty et Azerty) renvoie 1
        float left = Input.GetKey("a") ? -1 : 0; // Si le joueur appuie sur A (Qwerty) ou Q (Azerty) renvoie -1

        return left +  right;
    }


    // Permet de récupérer l'axe horizontale du J1
    float get_horizontal_J2() {

        float right = Input.GetKey("right") ? 1 : 0; // Si le joueur appuie sur D (Qwerty et Azerty) renvoie 1
        float left = Input.GetKey("left") ? -1 : 0; // Si le joueur appuie sur A (Qwerty) ou Q (Azerty) renvoie -1

        return left +  right;
    }
}

public enum direction {
    gauche, droite
};
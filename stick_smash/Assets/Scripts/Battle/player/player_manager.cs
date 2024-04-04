using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{

    public float move_direction;
    direction direction_looking;

    [SerializeField] player_controller J1;
    [SerializeField] player_controller J2;

    // Update is called once per frame
    void Update()
    {

        // Get Player Movement Input
        move_direction = Input.GetAxisRaw("Horizontal");

        verif_input_j1();
        verif_input_j2();
    }


    // Permet de vérifier si le J1 à appuyer sur des touches
    void verif_input_j1() {

        if (Input.GetKey("d")) {
            J1.verif_rotation(direction.droite);
            J1.move_right();
        }

        else if (Input.GetKey("a")) {            
            J1.verif_rotation(direction.gauche);
            J1.move_left();
        }

        if (Input.GetKey("space")) {

            J1.verif_jump();
        }
    }


    // Permet de vérifier si le J2 à appuyer sur des touches
    void verif_input_j2() {

        if (Input.GetKey("right")) {
            J2.verif_rotation(direction.droite);
            J2.move_right();
        }

        else if (Input.GetKey("left")) {            
            J2.verif_rotation(direction.gauche);
            J2.move_left();
        }

        if (Input.GetKey("[0]")) {

            J2.verif_jump();
        }
    }
}

public enum direction {
    gauche, droite
};
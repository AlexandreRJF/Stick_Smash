using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fist_controller : MonoBehaviour
{

    // Permet de détecter quand le perso arrive au sol
    void OnCollisionEnter2D(Collision2D hit_box) {

        if (hit_box.gameObject.transform.tag == "Player") {

            hit_box.gameObject.GetComponent<player_controller>().attaque_subit();
        }
    }
}

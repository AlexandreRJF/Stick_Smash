using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_zone : MonoBehaviour
{

    public game_manager Game_Manager;
    
    // Permet de détecter quand un joueur touche la killzone
    private void OnCollisionEnter2D(Collision2D hit_box) {
        
        kill_object(hit_box.gameObject);
        Game_Manager.call_main_victoire();
    }


    // Permet de détruire l'object entrant dans la kill zone
    private void kill_object(GameObject game_object_recu) {

        Destroy(game_object_recu);
    }
}

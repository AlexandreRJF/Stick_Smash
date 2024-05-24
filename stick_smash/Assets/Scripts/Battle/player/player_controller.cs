using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{

    // Int
    int vitesse;
    public int force_saut;
    int force_deplacement;

    // Float
    public float move_direction;
    public float horizontal_axis;
    
    // Bool
    direction direction_looking;
    public bool i_frames;
    
    // Componenets
    public SpriteRenderer sprite_renderer;
    public Rigidbody2D rb;

    // Scripts
    public game_manager Game_Manager;
    public fist_manager Fist_Manager;
    public pv_manager Pv_Manager;
    public jump_manager Jump_Manager;
    public mana_i_frames Mana_i_Frames;
    public bruitage_pv Bruitage_Pv;


    // Start is called before the first frame update
    void Start()
    {
        vitesse = 200;
        force_saut = 8;
        force_deplacement = 5;
        move_direction = 2;
        direction_looking = direction.droite;
        i_frames = false;
    }


    // Permet de lancer le saut
    public void player_jump() {
        Jump_Manager.verif_jump();
    }


    // Permet de vérifier que le joueur peut bouger
    public void verif_rotation(direction gauche_droite) {

        switch (gauche_droite) {

            case direction.gauche:
                
                if (direction_looking == direction.droite) {
                    transform.rotation = Quaternion.Euler(0,-180,0);
                }

            break;

            case direction.droite:
            
                if (direction_looking == direction.gauche) {
                    transform.rotation = Quaternion.Euler(0,0,0);
                }

            break;
        }
    }


    // Permet de vérifier que les conditions pour bouger sont réunis
    public void verif_move_player(direction direction_looking) {

        if (Fist_Manager.attack_on == false) {
            move_player(direction_looking);
        }
    }


    // Permet de faire bouger le joueur selon la direction qu'il input
    void move_player(direction direction_recu) {

        rb.velocity = new Vector2(horizontal_axis * force_deplacement, rb.velocity.y);
        direction_looking = direction_recu;
    }


    // Permet de lancer l'attaque
    public void player_attack() {

        Fist_Manager.attaque();
    }


    // Permet de savoir que le joueur est attaquer
    public void attaque_subit() {

        if (i_frames == false) {

            degats_subit();
            Bruitage_Pv.sound_effect_pv_perdu();
            Mana_i_Frames.main_i_frames();
        }

    }


    // Permet d'infliger des dégâts au joueur
    void degats_subit() {

        Pv_Manager.main_reduction_pv();

        if (Pv_Manager.verif_ko() == true) {
            
            mort();
        }
    }


    // Permet de tuer le personnage
    void mort() {

        Game_Manager.call_main_victoire();
        Destroy(gameObject);
    }
}

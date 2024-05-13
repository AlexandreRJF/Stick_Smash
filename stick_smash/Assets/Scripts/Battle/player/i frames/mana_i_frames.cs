using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mana_i_frames : MonoBehaviour
{

    // Bool
    bool J1_on_J2_off;

    // Animator
    public Animator animator_i_frames;

    // Sprite Renderer
    public SpriteRenderer sprite_renderer_i_frames;

    // Scripts
    [SerializeField] player_controller Player_Controller;


    // Start
    void Start() {

        sprite_renderer_i_frames.enabled = false;
    }


    // Permet d'executer le code nécessaire quand le joueur est attaquer
    public void main_i_frames() {

        sprite_renderer_i_frames.enabled = true;
        StartCoroutine(gestion_i_frames());
    }


    // Permet de lancer la séquence d'i frames en delay
    IEnumerator gestion_i_frames() {

        activation_i_frames();
        activation_anim_i_frames();

        yield return new WaitForSeconds(0.5f);

        desactivation_i_frames();
    }


    // Permet d'activer les i-frames
    void activation_i_frames() {

        Player_Controller.i_frames = true;
    }


    // Permet de désactiver les i-frames
    void desactivation_i_frames() {

        Player_Controller.i_frames = false;
    }


    // Permet d'activer l'animation d'I frames
    void activation_anim_i_frames() {

        animator_i_frames.Play("anim_i_frames", 0, 0);
    }
}

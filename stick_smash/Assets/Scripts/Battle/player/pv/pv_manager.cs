using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pv_manager : MonoBehaviour
{

    // Int
    public int pv_max;
    public int pv_actuelle;

    // GameObjects
    public List<GameObject> liste_go_coeur = new List<GameObject>();

    // Bool
    public bool i_frames;

    // Scripts
    [SerializeField] player_controller Player_Controller;

    // Start
    void Start() {

        pv_max = 3;
        pv_actuelle = pv_max;
        i_frames = false;

        affichage_coeur();
    }


    // Permet d'afficher les coeurs
    void affichage_coeur() {

        masquer_all_coeurs();

        for (int i = 0; i < pv_actuelle; ++i) {
            liste_go_coeur[i].SetActive(true);
        }
    }


    // Permet de masquer tout les coeurs
    void masquer_all_coeurs() {
    
        foreach(GameObject gameObject in liste_go_coeur) {

            gameObject.SetActive(false);
        }
    }


    // Permet de calculer les dégâts subits
    public bool calcule_degats() {
    
        if ((pv_actuelle - 1) > 0) {
        
            pv_actuelle -= 1;
            affichage_coeur();

            return false;
        }

        else {
            return true;
        }
    }
}

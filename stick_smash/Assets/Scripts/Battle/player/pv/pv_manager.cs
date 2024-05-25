using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pv_manager : MonoBehaviour
{

    // Int
    public int pv_max;
    public int pv_actuelle;

    // GameObjects
    public List<GameObject> liste_go_coeur = new List<GameObject>();

    // Bool


    // Scripts
    [SerializeField] player_controller Player_Controller;

    // Start
    void Start() {

        pv_max = 3;
        pv_actuelle = pv_max;

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
    public void masquer_all_coeurs() {
    
        foreach(GameObject gameObject in liste_go_coeur) {

            gameObject.SetActive(false);
        }
    }


    // Permet de call les fonctions nécessaire à perdre des PV
    public void main_reduction_pv() {

        reduction_pv();
        affichage_coeur();
    }


    // Permet de calculer les dégâts subits
    void reduction_pv() {

        pv_actuelle -= 1;
    }


    // Permet de savoir si le joueur est K.O
    public bool verif_ko() {

        if (pv_actuelle <= 0) {

            return true;
        }

        else {
            return false;
        }
    }
}

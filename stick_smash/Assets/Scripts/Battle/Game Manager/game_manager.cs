using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour
{

    // Scripts
    [SerializeField] private main_victoire Main_Victoire;

    // Bool
    public bool partie_fini;


    // Start
    void Start() {

        partie_fini = false;
    }


    // Permet de lancer la phase victoire
    public void call_main_victoire() {

        fin_partie();
        Main_Victoire.lancement_main_victoire();
    }


    // Permet d'aciver un ensemble de choses relatives à la fin de la partie
    void fin_partie() {

        partie_fini = true;
    }
}

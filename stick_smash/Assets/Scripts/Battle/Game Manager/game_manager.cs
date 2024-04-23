using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager : MonoBehaviour
{

    // Scripts
    [SerializeField] private main_victoire Main_Victoire;

    // Permet de lancer la phase victoire
    public void call_main_victoire() {

        Main_Victoire.lancement_main_victoire();
    }
}

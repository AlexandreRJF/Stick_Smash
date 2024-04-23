using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_victoire : MonoBehaviour
{
    
    // Scripts
    [SerializeField] private mana_victoire Mana_Victoire;

    // Permet de call la win
    public void lancement_main_victoire() {

        StartCoroutine(delay_affichage());
    }


    // Permet de delay l'affichage des boutons / texte victoire
    private IEnumerator delay_affichage() {

        yield return new WaitForSeconds(0.3f);

        Mana_Victoire.affichage_boutons(true);
        Mana_Victoire.gestion_victoire();
    }
}

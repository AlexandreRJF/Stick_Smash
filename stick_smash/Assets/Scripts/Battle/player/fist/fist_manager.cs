using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fist_manager : MonoBehaviour
{

    public GameObject go_poing;
    bool attack_on;

    // Start is called before the first frame update
    void Start() {
        
        go_poing.SetActive(false);
    }


    // Permet de lancer une attaque
    public void attaque() {

        if (attack_on == false) {
            StartCoroutine(affichage_poing());
        }
    }


    // Permet d'afficher le poing pendant une durée
    IEnumerator affichage_poing() {

        attack_on = true;
        go_poing.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        go_poing.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        attack_on = false;
    }
}

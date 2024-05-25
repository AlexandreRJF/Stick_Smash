using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fist_manager : MonoBehaviour
{

    public GameObject go_poing_sorti;
    public GameObject go_poing_rentre;
    public bool attack_on;
    bool end_lag;

    [SerializeField] private AudioSource audio_source_coup_poing;

    // Start is called before the first frame update
    void Start() {
        
        go_poing_rentre.SetActive(false);
        go_poing_sorti.SetActive(false);
    }


    // Permet de lancer une attaque
    public void attaque() {

        if (end_lag == false) {
            StartCoroutine(affichage_poing());
        }
    }


    // Permet d'afficher le poing pendant une durée
    IEnumerator affichage_poing() {

        attack_on = true;
        end_lag = true;
        go_poing_rentre.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        go_poing_rentre.SetActive(false);
        go_poing_sorti.SetActive(true);
        attack_on = false;

        yield return new WaitForSeconds(0.5f);
        go_poing_sorti.SetActive(false);
        end_lag = false;
    }


    // Permet de play le bruitage coup lancé
    public void bruitage_coup_inflige() {
        audio_source_coup_poing.Play(0);
    }
}

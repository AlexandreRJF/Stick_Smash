using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouton_quitter : MonoBehaviour
{

    [SerializeField] private GameObject go_bouton_quitter;

    // Start is called before the first frame update
    void Start()
    {
        gestion_bouton(false);
    }


    // Permet d'executer les méthodes nécessaires à afficher ou masquer le bouton
    public void gestion_bouton(bool on_off) {

        visibilite_bouton(on_off);
    }


    // Permet d'afficher ou masquer le bouton quitter
    private void visibilite_bouton(bool on_off) {

        go_bouton_quitter.SetActive(on_off);
    }


    // Permet d'executer les méthodes nécessaires à fermer le jeu
    public void gestion_quitter() {

        fermer_jeu();
    }


    // Permet de quitter la partie
    private void fermer_jeu() {

        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouton_rejouer : MonoBehaviour
{

    [SerializeField] private GameObject go_bouton_rejouer;

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

        go_bouton_rejouer.SetActive(on_off);
    }



    // Permet d'executer les méthodes nécessaires à fermer le jeu
    public void gestion_rejouer() {

        nouvelle_partie();
    }


    // Permet de quitter la partie
    private void nouvelle_partie() {

        SceneManager.LoadScene("Battle");
    }
}

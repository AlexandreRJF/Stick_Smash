using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mana_victoire : MonoBehaviour
{

    [SerializeField] private TMP_Text texte_victoire;

    [SerializeField] private bouton_rejouer Bouton_Rejouer;
    [SerializeField] private bouton_ecran_titre Bouton_Ecran_Titre;
    [SerializeField] private bouton_quitter Bouton_Quitter;

    [SerializeField] private AudioSource audio_source_you_win;

    // Start is called before the first frame update
    void Start()
    {
        texte_victoire.enabled = false;
    }


    // Permet de gérer les méthodes affichant la victoire
    public void gestion_victoire() {

        affichage_victoire();
        play_you_win();
    }


    // Permet d'afficher qu'un joueur à win
    private void affichage_victoire() {

        texte_victoire.enabled = true;
    }


    // Permet d'afficher ou masquer tout les boutons selon le bool reçu
    public void affichage_boutons(bool on_off) {

        affichage_bouton_rejouer(on_off);
        affichage_bouton_ecran_titre(on_off);
        affichage_bouton_quitter(on_off);
    }


    // Permet d'afficher ou masquer tout le bouton rejouer selon le bool reçu
    public void affichage_bouton_rejouer(bool on_off) {

        Bouton_Rejouer.gestion_bouton(on_off);
    }


    // Permet d'afficher ou masquer tout le bouton ecran titre selon le bool reçu
    public void affichage_bouton_ecran_titre(bool on_off) {

        Bouton_Ecran_Titre.gestion_bouton(on_off);
    }


    // Permet d'afficher ou masquer tout le bouton quitter selon le bool reçu
    public void affichage_bouton_quitter(bool on_off) {

        Bouton_Quitter.gestion_bouton(on_off);
    }


    // Permet de jouer le bruitage you win
    void play_you_win() {
        audio_source_you_win.Play(0);
    }
}

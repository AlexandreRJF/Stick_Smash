using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouton_jouer : MonoBehaviour
{
    
    // Permet de passer sur la scène battle field 1
    public void ouvrir_battle_field_1() {

        SceneManager.LoadScene("Battle 1");
    }


    // Permet de passer sur la scène battle field 2
    public void ouvrir_battle_field_2() {

        SceneManager.LoadScene("Battle 2");
    }
}

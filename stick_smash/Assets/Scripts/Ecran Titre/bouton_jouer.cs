using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bouton_jouer : MonoBehaviour
{
    
    // Permet de passer sur la scène battle field
    public void ouvrir_battle_field() {

        SceneManager.LoadScene("Battle");
    }
}

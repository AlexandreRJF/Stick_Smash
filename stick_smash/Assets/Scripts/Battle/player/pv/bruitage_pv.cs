using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bruitage_pv : MonoBehaviour
{

    public AudioSource audio_source_pv_perdu;

    // Permet de jouer le bruitage des PV perdus
    public void sound_effect_pv_perdu() {
        audio_source_pv_perdu.Play(0);
    }
}

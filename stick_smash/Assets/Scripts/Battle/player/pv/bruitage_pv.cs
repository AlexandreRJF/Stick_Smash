using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bruitage_pv : MonoBehaviour
{

    [SerializeField] private AudioSource audio_source_pv_perdu;
    [SerializeField] private AudioSource audio_source_coup_subit;

    // Permet de jouer le bruitage des PV perdus
    public void sound_effect_pv_perdu() {
        audio_source_pv_perdu.Play(0);
    }


    // Permet de jouer le bruitage des PV perdus
    public void sound_effect_coup_subit() {
        audio_source_coup_subit.Play(0);
    }
}

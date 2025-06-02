using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{

    public AudioSource Carro;
    public AudioClip[] audios;
    public AudioMixer mixer;


    public Slider master;

    public void PlayAudio(int indice)
    {
        Carro.clip = audios[indice];
        Carro.Play();
    }

    public void MudarVolume()
    {
        
            mixer.SetFloat("MasterVol", master.value);
            Debug.Log("oiiiii");
       

    }

}

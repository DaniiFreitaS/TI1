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
    public Slider effects;

    public void PlayAudio(int indice)
    {
        Carro.clip = audios[indice];
        Carro.Play();
    }

    public void MudarVolume()
    {
        mixer.SetFloat("MasterVol", master.value);
    }
    public void MudarVolumeEfeitos()
    {
        mixer.SetFloat("EffectsVol", effects.value);
    }

    public void Update()
    {
        MudarVolume();
    }

}

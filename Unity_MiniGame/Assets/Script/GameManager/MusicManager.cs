using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioMixer m_AudioMixer;
    [SerializeField] private Slider S_MusicMain;
    [SerializeField] private Slider S_MusicBGMs;
    [SerializeField] private Slider S_MusicSFXs;
    private void Awake()
    {
        S_MusicMain.onValueChanged.AddListener(SetMasterVolume);
        S_MusicBGMs.onValueChanged.AddListener(SetMusicVolume);
        S_MusicSFXs.onValueChanged.AddListener(SetSFXVolume);
    }

    public void SetMasterVolume(float volume)
    {
        m_AudioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
    }

    public void SetMusicVolume(float volume)
    {
        m_AudioMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
    }

    public void SetSFXVolume(float volume)
    {
        m_AudioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
}

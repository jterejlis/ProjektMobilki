using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider slideMenu;
    [SerializeField] private Slider sliderGame;


    private void Start()
    {
        if(PlayerPrefs.HasKey("MenuVolume") || PlayerPrefs.HasKey("GameVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMenuVolume();
            SetGameVolume();
        }
    }

    public void SetMenuVolume()

    {
        float volume = slideMenu.value;
        mixer.SetFloat("MenuVolume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("MenuVolume", volume);
    }

    public void SetGameVolume()

    {
        float volume = sliderGame.value;
        mixer.SetFloat("GameVolume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("GameVolume", volume);

    }

    private void LoadVolume()
    {
        slideMenu.value = PlayerPrefs.GetFloat("MenuVolume");
        sliderGame.value = PlayerPrefs.GetFloat("GameVolume");

        SetMenuVolume();
        SetGameVolume();
    }
    
    
    // Start is called before the first frame update
   
}

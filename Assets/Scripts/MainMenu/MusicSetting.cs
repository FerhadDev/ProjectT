using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MusicSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer _MyMixer;
    [SerializeField] private Slider _MusicSlider;
    [SerializeField] private Slider _SFXSlider;

    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();   
        }
    }

    public void SetMusicVolume()
    {
        float volume = _MusicSlider.value;
        _MyMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    public void SetSFXVolume()
    {
        float volume = _SFXSlider.value;
        _MyMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }

    private void LoadVolume()
    {
        _MusicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        _SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetMusicVolume();
        SetSFXVolume();
    }
}

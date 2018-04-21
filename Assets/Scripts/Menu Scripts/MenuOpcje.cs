using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuOpcje : MonoBehaviour {

    Resolution[] resolutions;
    public Dropdown resolutionDropdown;
    public Dropdown qualityDropdown;
    public Button btnWroc;
    public AudioMixer audioMixer;

    void Start()
    {
        btnWroc = GetComponent<Button>();


        //przygotowanie mozliwosci zmiany rozdzielczosci
        int actualQuality = QualitySettings.GetQualityLevel();
        qualityDropdown.RefreshShownValue();
        qualityDropdown.value = actualQuality;

        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
        for(int i=0;i<resolutions.Length;i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void setResolution(int index)
    {
        // wybor rozdzielczosci
        Resolution resolution = resolutions[index];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void setQuality(int index)
    {
        //wybor jakosci grafiki
        QualitySettings.SetQualityLevel(index);
    }

    public void setFullScreen(bool isFullScreen)
    {
        //opcja fullscreen
        Screen.fullScreen = isFullScreen;
    }

    public void nacisnijWroc()
    {
        SceneManager.LoadScene("Menu");
    }

    public void setMusicLvl(float lvl)
    {
        //ustawienie glosnosci muzyki
        audioMixer.SetFloat("MuzykaVol", lvl);
    }

}

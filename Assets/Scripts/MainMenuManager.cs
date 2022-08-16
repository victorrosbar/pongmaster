using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private int newGameScene;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private Slider volumeSlider;
    public AudioSource masterAudio;
    public TMPro.TextMeshProUGUI gameVersionText;

    private void Start()
    {
        gameVersionText.text = "v"+Application.version;
        volumeSlider.value = 0.5f;
    }

    public void NewGame(){
        SceneManager.LoadScene(newGameScene);
    }

    public void GoToOptions(){
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void GoToMainMenu(){
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void SetMasterVolume(){
        masterAudio.volume = volumeSlider.value;
    }
}

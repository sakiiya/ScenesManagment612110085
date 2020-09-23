using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _nextButton;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
        _nextButton.onClick.AddListener(delegate { NextToGameplayButtonClick(_nextButton); });
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneGameplay");
        SceneManager.LoadScene("SceneMainMenu");
    }

    public void NextToGameplayButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneGameplay");
        SceneManager.LoadScene("SceneGameplay2");
    }
}

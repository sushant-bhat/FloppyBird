using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameStatsScript _stats;
    [SerializeField] int _startSceneNo = 1;

    private void Awake()
    {
        FloppyBirdEvents.gameOverEvent.AddListener(OnGameOver);
        FloppyBirdEvents.gameStartEvent.AddListener(OnGameStart);
    }

    private void OnGameStart()
    {
        Time.timeScale = 1;
    }

    private void OnGameOver()
    {
        Time.timeScale = 0;
        _stats.ResetStats();
        FloppyBirdEvents.switchCanvasEvent.Invoke(Constants.CANVAS_TYPE.GameOverMenu);
    }
    
    void Start()
    {
        SceneManager.LoadScene(_startSceneNo);
        LoadMainMenu();
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 0;
        FloppyBirdEvents.switchCanvasEvent.Invoke(Constants.CANVAS_TYPE.MainMenu);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(Constants.GAME_SCENE_NAME);
        _stats.ShouldTakeInput = true;
        FloppyBirdEvents.switchCanvasEvent.Invoke(Constants.CANVAS_TYPE.InGameMenu);
    }

    public void ReloadGame()
    {
        Time.timeScale = 0;
        _stats.ResetStats();
        LoadGameScene();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

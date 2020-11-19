using UnityEngine;

[CreateAssetMenu(fileName = "GameStats", menuName = "Custom/GameStats")]
public class GameStatsScript : ScriptableObject
{
    [SerializeField] private int _gameScore;
    [SerializeField] private bool _gameStarted;
    [SerializeField] private bool _shouldTakeInput;

    public int GameScore { get => _gameScore; set => _gameScore = value; }
    public bool GameStarted { get => _gameStarted; set => _gameStarted = value; }
    public bool ShouldTakeInput { get => _shouldTakeInput; set => _shouldTakeInput = value; }

    private void OnEnable()
    {
        ResetStats();
    }

    public void ResetStats()
    {
        _gameScore = 0;
        _gameStarted = false;
        _shouldTakeInput = false;
    }
}

using UnityEngine;
using TMPro;

public class GameScorer : MonoBehaviour
{
    [SerializeField] GameStatsScript _stats;

    TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        FloppyBirdEvents.pointScoreEvent.AddListener(OnPointScore);
    }

    void Start()
    {
        scoreText.text = _stats.GameScore.ToString();
    }
    
    void Update()
    {
        scoreText.text = _stats.GameScore.ToString();
    }

    private void OnPointScore()
    {
        _stats.GameScore++;
    }
}

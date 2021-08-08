using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int _startScore = 10;
    private static int _score;
    private Text _scoreText;

    public static int Score
    {
        get => _score;
        set => _score = value;
    }

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
        _score = _startScore;
    }

    private void Update() => _scoreText.text = $"Score: {Score}";
}

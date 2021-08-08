using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private static float _currentTime;
    private static float _startTime = 30f;
    private Text _timeText;
    private string _specifier = "#";

    public static float CurrentTime
    {
        get => _currentTime;
        set => _currentTime = value;
    }

    private void Awake()
    {
        _timeText = GetComponent<Text>();
        CurrentTime = _startTime;
    }

    private void Update() => TimeRemaining();

    private void TimeRemaining()
    {
        _currentTime -= Time.deltaTime;
        _timeText.text = $"Time: {CurrentTime.ToString(_specifier)}";
    }

    public void TimeUpdate(int addTime)
    {
        _currentTime += addTime;
        _timeText.text = $"Time: {CurrentTime.ToString(_specifier)}";
    }
}

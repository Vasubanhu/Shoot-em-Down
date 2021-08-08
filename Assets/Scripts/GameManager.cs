#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    private AudioSource _audioSource;
    private int _sceneIndex = 1;

    private void Awake() => Resume();

    private void Start()
    {
        _audioSource = GameObject.FindGameObjectWithTag(Tags.MainCamera).GetComponent<AudioSource>();
    }

    private void Update()
    {
        GameOver();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }

    public void Play() => SceneManager.LoadScene(_sceneIndex);

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void GameOver()
    {
        if (TimeManager.CurrentTime <= 0 || ScoreScript.Score == 0)
        {
            _gameOverPanel.SetActive(true);
            _audioSource.Pause();

            Pause();
        }
    }

    private void Pause() => Time.timeScale = 0.0f;
    private void Resume() => Time.timeScale = 1.0f;
}

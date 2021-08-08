using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Settings:")]
    [SerializeField][Tooltip("Here you can adjust the intensity of the appearance of enemies.")]
    [Range(1, 3)] private float _spawnTime;
    [SerializeField][Tooltip("Here you can adjust the delay of the appearance of enemies.")]
    [Range(1, 3)] private float _spawnDelay;
    [SerializeField] private GameObject[] enemies;

    private bool _stopSpawning;

    private void Start() => InvokeRepeating(nameof(Spawn), _spawnTime, _spawnDelay);

    private void Spawn()
    {
        int index = Random.Range(0, enemies.Length);

        Instantiate(enemies[index], transform.position, transform.rotation);

        if (_stopSpawning)
        {
            CancelInvoke(nameof(Spawn));
        }        
    }
}

using UnityEngine;

public class BonusScript : MonoBehaviour
{
    [SerializeField] private GameObject _bonus;

    private static int _bonusTime = 3;
    private float _coefficient = 1.5f;
    private Vector2 _center = Vector2.zero;
    private Vector2 _stageDimensions;

    public static int BonusTime
    {
        get => _bonusTime;
    }

    public void SpawnBonus()
    {
        _stageDimensions = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Vector2 _position = _center + new Vector2(Random.Range(-_stageDimensions.x / _coefficient, 
                                                                _stageDimensions.x / _coefficient), 
                                                  Random.Range(-_stageDimensions.y / _coefficient, 
                                                                _stageDimensions.y / _coefficient));

        Instantiate(_bonus, _position, transform.rotation);
    }
}

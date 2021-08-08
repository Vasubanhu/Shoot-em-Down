using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider _charge;
    private bool _alreadySpawning;

    private void Start()
    {
        _charge.value = 0f;
        _charge.maxValue = 5f;
        _charge.wholeNumbers = true;
    }

    private void Update()
    {
        if (_charge.value == _charge.maxValue && !_alreadySpawning)
        {
            GameObject.FindGameObjectWithTag(Tags.BonusSpawner).GetComponent<BonusScript>().SpawnBonus();
            _alreadySpawning = true;
        }
        else if (!(_charge.value == _charge.maxValue) && _alreadySpawning)
        {
            _alreadySpawning = false;
        }
    }

    public void IncreaseCharge() => _charge.value++;

    public void ResetCharge() => _charge.value = 0f;
}

using UnityEngine;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    
    private float _scaleOffset = 1.05f;
    private float _normalScale = 1.0f;

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(_scaleOffset, _scaleOffset, _scaleOffset);

        if (tag == Tags.PlayButton) _gameManager.Play();
        if (tag == Tags.ExitButton) _gameManager.Quit();
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(_normalScale, _normalScale, _normalScale);
    }
}

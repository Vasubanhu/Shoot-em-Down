using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.CompareTag(Tags.ScreenEdge))
        {
            ScoreScript.Score--;
            Destroy(gameObject);
        }
    }

    private void Update() => transform.Translate(Vector3.right * _speed * Time.deltaTime);       
}

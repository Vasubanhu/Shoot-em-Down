using UnityEngine;

public class PlayerClick : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    
    private void Update() => Strike();

    private void Strike()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 raycastPosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                                  Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

            RaycastHit2D hit = Physics2D.Raycast(raycastPosition, Vector2.zero, 0f);

            if (hit)
            {
                GameObject gameObject = hit.transform.gameObject;

                if (gameObject.CompareTag(Tags.Cube) || gameObject.CompareTag(Tags.Vimana))
                {
                    ScoreScript.Score++;
                    GameObject.FindGameObjectWithTag(Tags.Slider).GetComponent<SliderScript>().IncreaseCharge();
                    Instantiate(_explosion, gameObject.transform.position, gameObject.transform.rotation);

                    Destroy(gameObject);
                }

                else if (gameObject.CompareTag(Tags.Bonus))
                {
                    GameObject.FindGameObjectWithTag(Tags.Time).GetComponent<TimeManager>().TimeUpdate(BonusScript.BonusTime);
                    GameObject.FindGameObjectWithTag(Tags.Slider).GetComponent<SliderScript>().ResetCharge();

                    Destroy(gameObject);
                }
            }
        }
    }
}

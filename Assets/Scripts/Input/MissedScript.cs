using UnityEngine;

public class MissedScript : MonoBehaviour
{
    private void OnMouseDown() => GameObject.FindGameObjectWithTag(Tags.Slider).GetComponent<SliderScript>().ResetCharge();
}

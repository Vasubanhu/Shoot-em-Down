using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    private Text _text;
    private Outline _outline;
    private float _time;
    private float _length = 1;
    private float _alphaOffset = 0.3f;
    private float _coeficient = 2.5f;

    private void Start()
    {
        _text = GetComponent<Text>();
        _outline = GetComponent<Outline>();
    }

    private void Update() => TextTransperency();

    private void TextTransperency()
    {
        _time = Time.time / _coeficient;
        _text.color = new Color(_text.color.r, _text.color.g, _text.color.b, Mathf.PingPong(_time, _length));

        _outline.effectColor = new Color(_outline.effectColor.r,
                                         _outline.effectColor.g,
                                         _outline.effectColor.b,
                                         _text.color.a - _alphaOffset);
    }
}

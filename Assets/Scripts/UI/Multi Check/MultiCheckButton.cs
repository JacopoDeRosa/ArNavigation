using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MultiCheckButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _off, _on;

    private bool _pressed;
    public bool Pressed { get => _pressed; }

    public event System.Action onPress;

    public void Init()
    {
        _image.sprite = _off;
        _pressed = false;
        onPress = null;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _image.sprite = _on;
        _pressed = true;
        onPress?.Invoke();
    }
}

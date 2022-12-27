using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMover : MonoBehaviour
{
    [SerializeField] private LineRenderer _renderer;
    [SerializeField] private float _speed;

    private Material _mat;
    private Vector2 _offset = Vector2.zero;

    private void Awake()
    {
        _mat = _renderer.material;
        foreach (string s in _mat.GetTexturePropertyNames())
        {
            Debug.Log(s);
        }
    }

    private void Update()
    {
        _offset.Set(_offset.x - _speed * Time.deltaTime, 0);
        _mat.SetTextureOffset("_MainTex", _offset);

    
    }
}

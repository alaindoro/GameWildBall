using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - _playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _playerTransform.position + _offset;
    }
}

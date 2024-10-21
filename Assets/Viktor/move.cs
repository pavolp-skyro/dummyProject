using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class move : MonoBehaviour
{
    [SerializeField] private Vector2 direction;
    [SerializeField] private float speed;
    void Update()
    {
        transform.Translate(direction.normalized * Time.deltaTime * speed);
    }
}

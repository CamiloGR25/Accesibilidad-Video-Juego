using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite : MonoBehaviour
{/*
    private Transform transformador;
    public Vector2 xRango = Vector2.zero;

    void Start()
    {
        transformador = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        transformador.position = new Vector3(Mathf.Clamp(transform.position.x, xRango.x, 0), transform.position.y, transform.position.z);
    }*/
    public float speed = 10f;
    public float minRangeX;
    public float maxRangeX;

    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        Vector3 newPosition = transform.position + new Vector3(xMove, 0, 0) * speed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, minRangeX, maxRangeX);
        transform.position = newPosition;
    }

}

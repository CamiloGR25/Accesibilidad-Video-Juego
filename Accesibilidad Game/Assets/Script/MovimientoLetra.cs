using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoLetra : MonoBehaviour
{
    bool derecha = false;
    bool izquierda = false;

    public Rigidbody2D rb; //Agarra el componente del Rigibody del objeto
    public float fuerzaMovimiento; //Fuerza de movimiento



    public void pulsarIzquierda()
    {
        izquierda = true;
    }
    public void pulsarDerecha()
    {
        derecha = true;
    }
    public void soltarIzquierda()
    {
        izquierda = false;
    }
    public void soltarDerecha()
    {
        derecha = false;
    }

    private void FixedUpdate()
    {
        if (izquierda)
        {
            rb.AddForce(new Vector2(-fuerzaMovimiento, 0) * Time.deltaTime);
        }
        if (derecha)
        {
            rb.AddForce(new Vector2(fuerzaMovimiento, 0) * Time.deltaTime);
        }
    }
}

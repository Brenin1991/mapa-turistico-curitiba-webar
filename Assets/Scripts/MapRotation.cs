using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotation : MonoBehaviour
{
    public GameObject mapa;
    private float velocidadeRotacao = 0.2f;
    private Vector2 toqueInicial;
    private float escalaInicial = 1f;
    private float fatorZoom = 0.01f;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch toque = Input.GetTouch(0);
            
            if (toque.phase == TouchPhase.Began)
            {
                toqueInicial = toque.position;
            }
            else if (toque.phase == TouchPhase.Moved)
            {
                float deslocamento = toque.position.x - toqueInicial.x;
                mapa.transform.Rotate(0, -deslocamento * velocidadeRotacao, 0);
                toqueInicial = toque.position;
            }
        }
        else if (Input.touchCount == 2)
        {
            Touch toque1 = Input.GetTouch(0);
            Touch toque2 = Input.GetTouch(1);
            
            float distanciaAtual = Vector2.Distance(toque1.position, toque2.position);
            float distanciaAnterior = Vector2.Distance(toque1.position - toque1.deltaPosition, toque2.position - toque2.deltaPosition);
            
            float delta = (distanciaAtual - distanciaAnterior) * fatorZoom;
            
            float novaEscala = Mathf.Clamp(mapa.transform.localScale.x + delta, escalaInicial * 0.5f, escalaInicial * 2f);
            mapa.transform.localScale = new Vector3(novaEscala, novaEscala, novaEscala);
        }
    }
}
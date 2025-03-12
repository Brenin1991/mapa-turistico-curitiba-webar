using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PontoToque : MonoBehaviour
{
    public UnityEvent onTouch;
    public Camera cameraPrincipal;

    void Start()
    {
        cameraPrincipal = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch toque = Input.GetTouch(0);

            if (toque.phase == TouchPhase.Began)
            {
                Ray ray = cameraPrincipal.ScreenPointToRay(toque.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform == transform)
                    {
                        onTouch?.Invoke();
                    }
                }
            }
        }
    }
}
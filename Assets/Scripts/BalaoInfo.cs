using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BalaoInfo : MonoBehaviour
{
    public GameObject balao;
    private Vector3 escalaInicial;
    public Camera cameraPrincipal;
    public bool isOpen = false;

    void Start()
    {
        escalaInicial = balao.transform.localScale;
        balao.transform.localScale = Vector3.zero;
        cameraPrincipal = Camera.main;
    }

    void Update()
    {
        OlharParaCamera();
    }

    public void MostrarBalao()
    {
	if(isOpen) {
	    StartCoroutine(EsconderBalao());
	} else {
	    StartCoroutine(AnimarBalao());
	}
        
    }

    private IEnumerator AnimarBalao()
    {
        float tempo = 0.5f;
        Vector3 escalaFinal = escalaInicial;
        isOpen = true;
        while (tempo > 0)
        {
            tempo -= Time.deltaTime;
            balao.transform.localScale = Vector3.Lerp(Vector3.zero, escalaFinal, 1 - tempo / 0.5f);
            yield return null;
        }
        
        yield return new WaitForSeconds(5f);
        isOpen = false;
        StartCoroutine(EsconderBalao());
    }

    private IEnumerator EsconderBalao()
    {
        float tempo = 0.5f;
        Vector3 escalaFinal = Vector3.zero;
        Vector3 escalaAtual = balao.transform.localScale;

        while (tempo > 0)
        {
            tempo -= Time.deltaTime;
            balao.transform.localScale = Vector3.Lerp(escalaAtual, escalaFinal, 1 - tempo / 0.5f);
            yield return null;
        }
        isOpen = false;
    }

    private void OlharParaCamera()
    {
        Vector3 direcao = balao.transform.position - cameraPrincipal.transform.position;
        direcao.y = 0;
        balao.transform.rotation = Quaternion.LookRotation(direcao);
    }
}

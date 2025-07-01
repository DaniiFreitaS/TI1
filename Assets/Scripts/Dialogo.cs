using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dialogo : MonoBehaviour
{
    public Image dialogo1;
    public Image dialogo2;
    public Image dialogo3;
    public Image dialogo4;
    public Image dialogo5;

    public GameObject tela;

    void Start()
    {
        tela.SetActive(false);
        StartCoroutine(MostrarDialogos());
    }

    IEnumerator MostrarDialogos()
    {
        dialogo1.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        dialogo1.gameObject.SetActive(false);

        dialogo2.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        dialogo2.gameObject.SetActive(false);

        dialogo3.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        dialogo3.gameObject.SetActive(false);

        dialogo4.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        dialogo4.gameObject.SetActive(false);

        dialogo5.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        dialogo5.gameObject.SetActive(false);

        tela.SetActive(true); // ou qualquer ação ao final do diálogo
    }
}

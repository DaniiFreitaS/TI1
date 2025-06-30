using UnityEngine;
using System.Collections;
public class Quadro : MonoBehaviour
{
    public GameObject quadro;
    void Start()
    {
        quadro.SetActive(true);
        StartCoroutine(DesativarDepoisDe10Segundos());
        Time.timeScale = 0f;
    }

    IEnumerator DesativarDepoisDe10Segundos()
    {
        yield return new WaitForSeconds(10f);
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}

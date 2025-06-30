using UnityEngine;

public class PlayerTiro : MonoBehaviour
{
    public GameObject prefabTiro;
    public Transform pontoDisparo;
    public GameObject tela;
    public bool fase2 = false;


    void Start()
    {
        tela = GameObject.FindGameObjectWithTag("Tela");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!fase2)
            {
                Instantiate(prefabTiro, pontoDisparo.position + pontoDisparo.forward, pontoDisparo.rotation, tela.transform);

            }
            else
            {
                Instantiate(prefabTiro, pontoDisparo.position + pontoDisparo.up, pontoDisparo.rotation, tela.transform);
                prefabTiro.GetComponent<TiroController>().fase2 = true;
            }
        }
    }
}
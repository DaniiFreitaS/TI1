using UnityEngine;

public class PlayerTiro : MonoBehaviour
{
    public GameObject prefabTiro;
    public Transform pontoDisparo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabTiro, pontoDisparo.position, pontoDisparo.rotation);
        }
    }
}
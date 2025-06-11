using UnityEngine;

public class InstanciadorInimigos : MonoBehaviour
{
    public GameObject prefabInimigo;
    public GameObject tela;
    public float intervalo = 2f;

    private float proximoSpawn;

    void Start()
    {
        tela = GameObject.FindGameObjectWithTag("Tela");
        proximoSpawn = Time.time + intervalo;
    }

    void Update()
    {
        if (Time.time >= proximoSpawn)
        {
            GameObject[] inimigos = GameObject.FindGameObjectsWithTag("Inimigo");

            if (inimigos.Length < 3)
            {
                Instantiate(prefabInimigo, transform.position, Quaternion.identity, tela.transform);

            }

            proximoSpawn = Time.time + intervalo;
        }
    }
}

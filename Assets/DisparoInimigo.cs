using UnityEngine;

public class DisparoInimigo : MonoBehaviour
{
    public GameObject prefabTiro;
    public float intervalo = 2f;
    public float velocidadeTiro = 5f;

    private float tempoProximoTiro;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        tempoProximoTiro = Time.time + intervalo;
    }

    void Update()
    {
        if (player != null && Time.time >= tempoProximoTiro)
        {
            Atirar();
            tempoProximoTiro = Time.time + intervalo;
        }
    }

    void Atirar()
    {
        // Instancia a bomba
        GameObject tiro = Instantiate(prefabTiro, transform.position, Quaternion.identity);

    }
}

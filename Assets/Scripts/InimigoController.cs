using UnityEngine;

public class InimigoController : MonoBehaviour
{
    public int vida = 5;

    private float velocidade = 10f;
    private float limiteEsquerdo = -30f;
    private float limiteDireito = 30f;

    public GameObject prefabTiro;
    public Transform pontoDisparo;
    public float tempoEntreTiros = 10f;

    private float tempoProximoTiro;
    private int direcao = 1;

    private Transform alvo;

    public GameObject explosaoPrefab = null; // futuro efeito visual

    void Start()
    {
        vida = 5;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            alvo = player.transform;
        }
    }

    void Update()
    {
        // Movimento no eixo X
        transform.Translate(Vector3.right * direcao * velocidade * Time.deltaTime);

        if (transform.position.x >= limiteDireito)
            direcao = -1;
        else if (transform.position.x <= limiteEsquerdo)
            direcao = 1;

        // Atira se for a hora
        if (alvo != null && Time.time >= tempoProximoTiro)
        {
            //Debug.Log("Inimigo atirou");
            Atirar();
            tempoProximoTiro = Time.time + tempoEntreTiros;
        }
    }

    void Atirar()
    {
        // Instancia a bomba
        GameObject tiro = Instantiate(prefabTiro, pontoDisparo.position, Quaternion.identity);
        Destroy(tiro, 10f); // Destrói o tiro após 10 segundos}

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("TiroPlayer"))
        {
            Debug.Log("teste");
            vida--;
            if (vida <= 0)
            {
                Explodir();
            }
        }
    }

    void Explodir()
    {
        if (explosaoPrefab != null)
        {
            Instantiate(explosaoPrefab, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}

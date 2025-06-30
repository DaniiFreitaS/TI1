using UnityEngine;
using UnityEngine.SceneManagement;

public class InimigoController : MonoBehaviour
{
    public int vida = 20;

    private float velocidade = 10f;
    private float limiteEsquerdo = -10f;
    private float limiteDireito = 25f;

    public GameObject prefabTiro;
    public GameObject prefabMissil;
    public Transform pontoDisparo;
    public float tempoEntreTiros = 10f;

    private float tempoProximoTiro;
    private int direcao = 1;

    private Transform alvo;

    public GameObject hitParticle;

    public GameObject explosaoPrefab = null; // futuro efeito visual

    public GameObject dropVida;

    void Start()
    {
        vida = 20;

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
        int range = Random.Range(0, 2);
        Debug.Log(range);
        if (range == 0)
        {
            
            GameObject tiro = Instantiate(prefabTiro, pontoDisparo.position, prefabTiro.transform.rotation);
            Destroy(tiro, 10f); // Destrói o tiro após 10 segundos}
        }
        else
        {
            Debug.Log("0");
            GameObject tiro = Instantiate(prefabMissil, pontoDisparo.position, prefabMissil.transform.rotation);
            Destroy(tiro, 10f); // Destrói o tiro após 10 segundos}
        }


    }
    void AtirarVida()
    {
        GameObject tiro = Instantiate(dropVida, pontoDisparo.position, Quaternion.identity);
        Destroy(tiro, 10f); // Destrói o tiro após 10 segundos}
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("TiroPlayer"))
        {
            Debug.Log("teste");
            vida--;
            ExplosaoInstanciet();
            if (vida <= 0)
            {
                Explodir();
                ExplosaoInstanciet();
            }
            if (vida < 20 && vida % 5 == 0)
            {
                AtirarVida();
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
        SceneManager.LoadScene("TelaVitoria");
    }

    public void ExplosaoInstanciet()
    {
        GameObject hit = Instantiate(hitParticle, this.transform.position, Quaternion.identity);
        Destroy(hit, 1f);
    }
}

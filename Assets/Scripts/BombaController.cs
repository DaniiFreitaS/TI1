using UnityEngine;

public class BombaController : MonoBehaviour
{
    public int vida = 1;
    public int dano = 1;
    public GameObject explosaoPrefab = null; // futuro efeito visual
    public GameObject hitParticle;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            // A bomba para de se mexer quando bate no piso
            GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            GetComponent<Rigidbody>().isKinematic = true;
        }


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

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerVida player = collision.gameObject.GetComponent<PlayerVida>();
            if (player != null)
            {
                player.ReceberDano(1); // Aplica 1 de dano
            }

            Explodir();
        }
    }

    void Explodir()
    {
        Instantiate(explosaoPrefab, transform.position, Quaternion.identity);
        ExplosaoInstanciet();
        Destroy(gameObject);
    }

    public void ExplosaoInstanciet()
    {
        GameObject hit = Instantiate(hitParticle, this.transform.position, Quaternion.identity);
        Destroy(hit, 1f);
    }
}

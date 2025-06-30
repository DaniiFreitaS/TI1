using UnityEngine;

public class VidaColetavel : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            // A bomba para de se mexer quando bate no piso
            GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("vida no chao");
        }



    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("vida pegou");
            PlayerVida player = collision.gameObject.GetComponent<PlayerVida>();
            if (player != null)
            {
                player.ReceberDano(-1); // Aplica 1 de dano
            }
            Destroy(gameObject);
        }
    }
}

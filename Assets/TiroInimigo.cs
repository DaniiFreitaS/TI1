using UnityEngine;

public class TiroInimigo : MonoBehaviour
{

    void Start()
    {
        //Destroy(gameObject, 15f); // Destrói o tiro após 5 segundos}
    }
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tiro colidiu com: " + other.name);
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            player.ReceberDano(1); // Aplica 1 de dano
        }
    }
}

using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class EnemyShooter : MonoBehaviour
{
    public float velocidade = 100f;
    public float tempoDestruir = 5f;

    void Start()
    {
        Destroy(this.gameObject, tempoDestruir);
    }

    void Update()
    {
        
        transform.Translate(-Vector3.up * velocidade * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("oi");
            PlayerVida player = other.gameObject.GetComponent<PlayerVida>();
            player.ReceberDano(1);
            Destroy(this.gameObject);
        }
    }
}

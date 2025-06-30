using UnityEngine;

public class TiroController : MonoBehaviour
{
    public float velocidade = 100f;
    public float tempoDestruir = 5f;
    public bool fase2 = false;

    void Start()
    {
        Destroy(this.gameObject, tempoDestruir);
    }

    void Update()
    {
        if (fase2 == false) {
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.up * velocidade * Time.deltaTime);
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("oi");
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
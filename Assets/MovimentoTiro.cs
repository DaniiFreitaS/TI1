using UnityEngine;

public class MovimentoTiro : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * 10000f * Time.deltaTime);
        Destroy(this.gameObject, 5);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {

        }
        else
        {
            Destroy(this.gameObject);

        }
    }
}

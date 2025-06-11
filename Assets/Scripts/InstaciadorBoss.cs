using UnityEngine;

public class InstaciadorBoss : MonoBehaviour
{

    public GameObject prefabInimigo;
    public GameObject tela;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tela = GameObject.FindGameObjectWithTag("Tela");
        Instantiate(prefabInimigo, transform.position, Quaternion.identity, tela.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

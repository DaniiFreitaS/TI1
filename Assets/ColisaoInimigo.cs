using UnityEngine;

public class ColisaoInimigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int pontuacao = 0;
    void Start()
    {
        pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        pontuacao++;
        Debug.Log(pontuacao);
    }
}


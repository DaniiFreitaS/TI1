using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
    public int posicaoLinha;
    public event Action<EnemyController> Falecimento;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Teste para ver se os inimigos aparecem infinitamente
        //Invoke("Morrer", 2f);
    }

    public void Morrer()
    {
        Falecimento?.Invoke(this);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Morrer();
    }
}

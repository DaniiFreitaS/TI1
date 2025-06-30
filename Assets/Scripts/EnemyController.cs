using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
    public int posicaoLinha;
    public event Action<EnemyController> Falecimento;
    public Pontuacao pontuacao;
    public GameObject prefabTiro;
    public Transform pontoDisparo;
    public GameObject tela;
    void Start()
    {
       pontuacao = FindAnyObjectByType<Pontuacao>();
        tela = GameObject.FindGameObjectWithTag("Tela");
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
        pontuacao.AdicionarPontos(10);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Morrer();
    }

    public void Shoot()
    {
        Instantiate(prefabTiro, pontoDisparo.position - pontoDisparo.up, pontoDisparo.rotation, tela.transform);

    }
}

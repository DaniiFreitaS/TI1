using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVida : MonoBehaviour
{
    public int vida = 3;
    private bool morto = false;
    public bool fase2 = false;

    public static event Action<int> OnVidaAtualizada;

    public void ReceberDano(int quantidade)
    {
        if (morto) return;

        vida -= quantidade;
        OnVidaAtualizada?.Invoke(vida);

        if (vida <= 0)
        {
            Morrer();
        }
        if (vida > 3) 
        {
            vida = 3;
        }
    }

    void Morrer()
    {
        Debug.Log("Player morreu!");
        morto = true;
        gameObject.SetActive(false);
        if (fase2)
        {
            SceneManager.LoadScene("Derrota2");
        }
        else
        {
            SceneManager.LoadScene("TelaDerrota");
        }
    }

    public bool EstaMorto()
    {
        return morto;
    }
}
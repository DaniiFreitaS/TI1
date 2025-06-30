using TMPro;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int score;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        AtualizarTexto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdicionarPontos(int valor)
    {
        Debug.Log("teste");
        score += valor;
        AtualizarTexto();
    }

    public void AtualizarTexto()
    {
        if (text == null)
        {
            Debug.Log("erro");
        }
        text.text = "Score : " + score;
        Debug.Log("teste2");
    }
}

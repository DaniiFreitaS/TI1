using UnityEngine;
using UnityEngine.UI;

public class UIVida : MonoBehaviour
{
    [Header("Configuração das Vidas")]
    public Image[] coracoes;
    public Sprite coracaoCheio;
    public Sprite coracaoVazio;

    private void OnEnable()
    {
        PlayerVida.OnVidaAtualizada += AtualizarVida;
    }

    private void OnDisable()
    {
        PlayerVida.OnVidaAtualizada -= AtualizarVida;
    }

    public void AtualizarVida(int vidaAtual)
    {
        for (int i = 0; i < coracoes.Length; i++)
        {
            coracoes[i].sprite = i < vidaAtual ? coracaoCheio : coracaoVazio;
        }
    }
}
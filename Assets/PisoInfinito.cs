using UnityEngine;

public class PisoInfinito : MonoBehaviour
{
    public Transform[] pisos; // Os 4 pisos
    public Transform tela;    // O objeto que avança
    public float comprimentoTile = 50f;

    void Update()
    {
        foreach (Transform piso in pisos)
        {
            // Se o piso está muito para trás da tela, reposiciona ele para frente
            if (piso.position.z + comprimentoTile * 1.5f < tela.position.z)
            {
                // Encontra o mais à frente e posiciona depois dele
                float maiorZ = EncontrarMaiorZ();
                piso.position = new Vector3(piso.position.x, piso.position.y, maiorZ + comprimentoTile);
            }
        }
    }

    float EncontrarMaiorZ()
    {
        float maior = float.MinValue;
        foreach (Transform piso in pisos)
        {
            if (piso.position.z > maior)
                maior = piso.position.z;
        }
        return maior;
    }
}

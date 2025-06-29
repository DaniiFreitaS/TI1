using UnityEngine;

public class PlayerMira : MonoBehaviour
{
    public Transform arma;
    public float rotacaoSpeed = 30f;
    private float anguloMax = 0f;
    private float anguloMin = -10f;

    private float anguloAtual = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            anguloAtual -= rotacaoSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            anguloAtual += rotacaoSpeed * Time.deltaTime;

        anguloAtual = Mathf.Clamp(anguloAtual, anguloMin, anguloMax);
        arma.localRotation = Quaternion.Euler(anguloAtual, 0f, 0f);
    }
}
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float str = 10f;  // Variável pública
    private CharacterController controller;  // Variável privada

    public Transform arma;


    public int vida = 3;

    public float velocidadeRotacao = 30f;
    public float limiteSuperior = 0f;
    public float limiteInferior = -45f;

    private float anguloVertical = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();  // Inicializa o CharacterController
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Criando o vetor de movimento usando os inputs "horizontal e vertical" * a força * tempo
        Vector3 move = new Vector3(horizontal, 0f , vertical) * str * Time.deltaTime;

        // Calcula a direção que vai se movimentar somando a posição atual + a do input
        Vector3 nextPosition = transform.localPosition + move;

        // Impede o movimento além dos limites no eixo Z
        if (nextPosition.z > 40f)
        { move.z = 0f; }
        if (nextPosition.z < -10f)
        { move.z = 0f; }

        // Impede o movimento além dos limites no eixo X
        if (nextPosition.x > 70f)
        { move.x = 0f; }
        if (nextPosition.x < -70f)
        { move.x = 0f; }


        controller.Move(move);
        rotacaoArma();
        //Debug.Log("movimento");
    }

    public void rotacaoArma()
    {
        // Pressione as teclas para ajustar a mira vertical
        if (Input.GetKey(KeyCode.Q)) // Mira para cima
            anguloVertical -= velocidadeRotacao * Time.deltaTime;

        if (Input.GetKey(KeyCode.E)) // Mira para baixo
            anguloVertical += velocidadeRotacao * Time.deltaTime;

        // Limita o ângulo entre mínimo e máximo
        anguloVertical = Mathf.Clamp(anguloVertical, limiteInferior, limiteSuperior);

        // Aplica a rotação apenas no eixo X (vertical)
        arma.localRotation = Quaternion.Euler(anguloVertical, 0f, 0f);
    }

    // Método para receber dano
    public void ReceberDano(int quantidade)
    {
        vida -= quantidade;

        Debug.Log("Player levou dano! Vida restante: " + vida);

        // Verifica se morreu
        if (vida <= 0)
        {
            Morrer();
        }
    }

    void Morrer()
    {
        Debug.Log("Player morreu!");
        // Aqui você pode:
        // - Desativar o jogador
        // - Tocar animação
        // - Chamar Game Over
        gameObject.SetActive(false);
        Time.timeScale = 0f;

    }

}




/*
 
 if (Input.GetAxis("Vertical") > 0) {
            rb.AddForce(Vector3.forward * forceAmount * Time.deltaTime);
            Debug.Log("movimento");

        }
 */
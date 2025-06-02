using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject painelPausa;
    private bool jogoPausado = false;

    void Start()
    {
        painelPausa.SetActive(false); // desativa no início
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (jogoPausado)
                Retomar();
            else
                Pausar();
        }
    }

    public void Pausar()
    {
        painelPausa.SetActive(true);
        Time.timeScale = 0f;
        jogoPausado = true;
    }

    public void Retomar()
    {
        painelPausa.SetActive(false);
        Time.timeScale = 1f;
        jogoPausado = false;
    }

    public void VoltarMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuInicial"); // ajuste para o nome da sua cena de menu
    }
}

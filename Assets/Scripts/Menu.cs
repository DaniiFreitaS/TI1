using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject painelPausa;
    public GameObject painelConfig;
    private bool jogoPausado = false;

    void Start()
    {
        painelPausa.SetActive(true);
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
        Debug.Log("teste3");
        SceneManager.LoadScene("Fase1"); // ajuste para o nome da sua cena de menu
    }

    public void Sair()
    {
        Application.Quit();

    }

    public void Config()
    {
        this.gameObject.SetActive(false);
        painelConfig.SetActive(true);
        painelPausa.SetActive(false);
    }

    public void MenuInicio()
    {
        this.gameObject.SetActive(true);
        painelConfig.SetActive(false);
        painelPausa.SetActive(true);
    }
}

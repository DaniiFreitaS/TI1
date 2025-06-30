using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasVitoria : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fase2()
    {
        SceneManager.LoadScene("Fase 2");
    }
    public void MenuInicio()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Sair()
    {
        Application.Quit();
    }
}

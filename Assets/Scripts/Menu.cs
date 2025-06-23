using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jogar()
    {
        SceneManager.LoadScene("Fase1");
    }
    public void Sair()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo.");
    }
}

using UnityEngine;
using System.Collections;
public class Quadro : MonoBehaviour
{
    public GameObject quadro;
    void Start()
    {
        quadro.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Skip()
    {
        quadro.SetActive(false);
        Time.timeScale = 1f;
    }
    
}

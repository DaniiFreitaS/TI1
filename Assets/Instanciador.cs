using UnityEngine;

public class Instanciador : MonoBehaviour
{

    public GameObject prefab;
    public GameObject tela;
    public Transform arma;
    
    void Start()
    {
        tela = GameObject.FindGameObjectWithTag("Tela");
    }

    void Update()
    {
        //instancia os tiros da arma do player
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(prefab, arma.position + arma.forward, arma.rotation, tela.transform);

        }

    }

}

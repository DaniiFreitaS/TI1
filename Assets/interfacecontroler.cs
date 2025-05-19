using UnityEngine;

public class interfacecontroler : MonoBehaviour
{
   public GameObject vida1, vida2,vida3;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TomarDano()
    {
        if (vida1 != null)
        {
            vida1.SetActive(false);
        }
        else if (vida2 != null)
        {
            vida2.SetActive(false);
        }
        else if (vida3 != null)
        {
            vida2.SetActive(false);
        }
    }
}

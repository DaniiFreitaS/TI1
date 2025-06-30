using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public GameObject shieldVisual; // O objeto visual do escudo
    public float shieldDuration = 5f;
    public float cooldownDuration = 15f;

    private bool shieldActive = false;
    private bool isOnCooldown = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !shieldActive && !isOnCooldown)
        {
            ActivateShield();
        }
    }

    void ActivateShield()
    {
        shieldActive = true;
        isOnCooldown = true;

        // Ativa o visual do escudo
        shieldVisual.SetActive(true);

        // Desativa o escudo após o tempo de duração
        Invoke(nameof(DeactivateShield), shieldDuration);

        // Libera o escudo novamente após o cooldown
        Invoke(nameof(ResetCooldown), cooldownDuration);
    }

    void DeactivateShield()
    {
        shieldActive = false;
        shieldVisual.SetActive(false);
    }

    void ResetCooldown()
    {
        isOnCooldown = false;
    }
}

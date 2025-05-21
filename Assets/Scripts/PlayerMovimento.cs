using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovimento : MonoBehaviour
{
    public float velocidade = 10f;
    private CharacterController controller;

    public float limiteX = 70f;
    public float limiteZMax = 40f;
    public float limiteZMin = -10f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0f, v) * velocidade * Time.deltaTime;
        Vector3 next = transform.localPosition + move;

        if (next.z > limiteZMax || next.z < limiteZMin)
            move.z = 0f;

        if (next.x > limiteX || next.x < -limiteX)
            move.x = 0f;

        controller.Move(move);
    }
}
using UnityEngine;

public class LigarDeslga : MonoBehaviour
{
    public Vector3 rotationAngle = new Vector3(0, 90, 0); // �ngulo de rota��o desejado em graus
    public float duration = 3f; // Dura��o da rota��o em segundos
    public Tig? tig;
    private float timeElapsed = 0f;
    private bool emAnimacaco = false;
    private bool inverso = true;
    private Quaternion initialRotation;
    private Quaternion targetRotation;
    public System.Func<bool, int>? func;
    public
    void Start()
    {
        // Guarda a rota��o inicial e calcula a rota��o final
        initialRotation = transform.rotation;
        targetRotation = initialRotation * Quaternion.Euler(rotationAngle);
    }

    void Update()
    {
        if (emAnimacaco)
        {
            timeElapsed += Time.deltaTime;
            float progress = timeElapsed / duration;
            if (!inverso)
            {
                transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, progress);
            }
            else
            {
                transform.rotation = Quaternion.Slerp(targetRotation, initialRotation, progress);
            }
            if (timeElapsed > duration)
            {
                emAnimacaco = false;
                timeElapsed = 0f;
            }
        }
    }

    public void Inverter()
    {
        if (emAnimacaco) return;
        emAnimacaco = true;
        inverso = !inverso;
        if (tig is not null)
        {
            tig.SetIsLeverOn1(!inverso);
        }
        if (func is not null)
        {
            func(!inverso);
        }
    }
    public bool GetOn()
    {
        return !inverso;
    }
}

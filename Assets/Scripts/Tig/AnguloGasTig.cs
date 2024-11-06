using UnityEngine;

public class AnguloGasTig : MonoBehaviour
{
    public Rotator rotator;
    public float valor;
    public Transform trans;
    private int ultimoAngulo;
    public float ultimoAnguloRotacao;
    private Quaternion rotacaoInicial;
    private bool lastOnOff;
    public LigarDeslga animacao;
    public TochaTig tig;
    // Start is called before the first frame update
    void Start()
    {
        ultimoAngulo = rotator.angulo;
        lastOnOff = animacao.GetOn();
        rotacaoInicial = trans.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastOnOff != animacao.GetOn())
        {
            lastOnOff = animacao.GetOn();
            if (animacao.GetOn() == false)
            {
                trans.rotation = rotacaoInicial;
                ultimoAnguloRotacao = -100;
                tig.SetIsGasOn(false);
            }
            else
            {
                UpdatePalitoAngle();
            }
        }
        else
        {
            if (lastOnOff && ultimoAngulo != rotator.angulo)
            {
                ultimoAngulo = rotator.angulo;
                UpdatePalitoAngle();
            }
        }
    }

    void UpdatePalitoAngle()
    {
        float novoAngulo;
        if (ultimoAngulo <= 90)
        {
            if (ultimoAngulo == 0)
            {
                tig.SetIsGasOn(false);
            }
            else
            {
                tig.SetIsGasOn(true);
            }
            novoAngulo = -100 + ultimoAngulo * 0.312509f;
        }
        else
        {
            novoAngulo = -1 * (-0.1708f * ultimoAngulo + 87.417f);
            tig.SetIsGasOn(true);
        }
        trans.Rotate(0, 0, ultimoAnguloRotacao - novoAngulo);
        ultimoAnguloRotacao = novoAngulo;
    }
}

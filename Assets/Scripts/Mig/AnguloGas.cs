using UnityEngine;

public class AnguloGas : MonoBehaviour
{
    public Rotator rotator;
    public float valor;
    public Transform trans;
    private int ultimoAngulo;
    public float ultimoAnguloRotacao;
    private Quaternion rotacaoInicial;
    private bool lastOnOff;
    public AnimacaoAbrirFechar animacao;
    public TochaMig mig;
    // Start is called before the first frame update
    void Start()
    {
        ultimoAngulo = rotator.angulo;
        lastOnOff = animacao.aberto;
        rotacaoInicial = trans.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastOnOff != animacao.aberto)
        {
            lastOnOff = animacao.aberto;
            if (animacao.aberto == false)
            {
                trans.rotation = rotacaoInicial;
                ultimoAnguloRotacao = -100;
                mig.SetIsGasOn(false);
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
                mig.SetIsGasOn(false);
            }
            else
            {
                mig.SetIsGasOn(true);
            }
            novoAngulo = -100 + ultimoAngulo * 0.312509f;
        }
        else
        {
            novoAngulo = -1 * (-0.1708f * ultimoAngulo + 87.417f);
            mig.SetIsGasOn(true);
        }
        trans.Rotate(ultimoAnguloRotacao - novoAngulo, 0, 0);
        ultimoAnguloRotacao = novoAngulo;
    }
}

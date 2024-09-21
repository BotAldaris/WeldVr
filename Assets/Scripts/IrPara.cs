using UnityEngine;
using UnityEngine.SceneManagement;

public class IrPara : MonoBehaviour
{
    public void Ir(string nome)
    {
        SceneManager.LoadScene(nome);
    }
}

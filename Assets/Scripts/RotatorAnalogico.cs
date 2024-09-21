using System.Collections.Generic;
using UnityEngine;

public class RotatorAnalogico : MonoBehaviour
{
    private bool selected;
    public List<float> angle;
    public int index = 0;
    private bool negative;
    private bool ativo;

    // Update is called once per frame
    void Update()
    {
        if (selected && ativo)
        {
            ativo = false;
            if (index != 0 && negative)
            {
                transform.Rotate(-angle[--index], 0, 0);
           
            }
            else if (angle.Count > index && !negative) {
                transform.Rotate(angle[index], 0, 0);
                index++;
            }
        }
    }
    public void SetSelected(bool selected)
    {
        this.selected = selected;
    }
    public void SetNegative(bool isNegative)
    {
        negative = isNegative;
    }
    public void SetActive(bool active)
    {
        ativo = active;
    }
}

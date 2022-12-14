using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIO5 : MonoBehaviour
{
    public float Y;
    public float Z;
    public float X;

    private bool LimitBounds(float LIMX, float LIMY, float LIMZ)//los absolutos que habrán sobre los valores
    {
        if (transform.position.x <= LIMX && transform.position.y <= LIMY && transform.position.z <= LIMZ)
        {
            return true;//estando entre sus tres limites de variables, valdrá true.
        }
        if (transform.position.x >= (-1 * LIMX) && transform.position.y >= (-1 * LIMY) && transform.position.z >= (-1 * LIMZ))
        {
            return true;//estando entre sus tres limites, valdrá true
        }
        else
        {
            return false;//si no pertenece a estos limites, será false
        }





    }

    private void Start()
    {
        LimitBounds(X, Y, Z);

            if (LimitBounds(X, Y, Z) == true)
        {
            Debug.Log(message: $"The object is not out of limits");
        }
        else
        {
            Debug.Log(message: $"The object is out of limits");
        }
    }
}
        

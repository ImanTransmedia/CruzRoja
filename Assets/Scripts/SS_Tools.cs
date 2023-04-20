/* 
 Uso exclusivo de ImanTransmedia
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class SS_Tools
{
    public static float MedirDistancia(GameObject object1, GameObject object2, Color color, GameObject Texto)
    {
        float distance = Vector3.Distance(object1.transform.position, object2.transform.position);

        // Dibuja la linea 
        Debug.DrawLine(object1.transform.position, object2.transform.position, color);

        // Coloca la distancia en TextMeshPro
        TextMeshProUGUI textMeshPro = Texto.GetComponent<TextMeshProUGUI>(); 

        if (textMeshPro != null)
        {
            textMeshPro.text = distance.ToString("F2");
        }

        return distance;
    }

}

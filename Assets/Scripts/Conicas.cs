using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conicas : MonoBehaviour
{
    public Text txtConicas;
    private int conicaSeleccionada = 0; //0- Sin selección, 1- Recta, 2- Circunferencia, 3- Elipse, 4- Parabola, 5- Hiperbola
    
    public Slider sl_a;
    private float a=5;

    public Slider sl_b;
    private float b=5;

    public Slider sl_h;
    private float h=1;

    public Slider sl_k;
    private float k=1;

    public Slider sl_t;
    private float t=45;

    private int resolucion = 1000;

    public Text lbl_a, lbl_b, lbl_h, lbl_k, lbl_t;
    public Material matRecta, matCircunferencia, matElipse, matParabola, matHiperbola;

    private Vector3[] posPuntos;

    public void DibujaConica()
    {
        if (conicaSeleccionada !=0)
        {
           switch (conicaSeleccionada)
            {
                case 1://Recta
                    txtConicas.text = "Recta"; 
                    break;
                case 2://Circunferencia
                    txtConicas.text = "Circunferencia"; 
                    break;
                case 3://Elipse
                    txtConicas.text = "Elipse";
                    break;
                case 4://Parabola
                    txtConicas.text = "Parábola";
                    break;
                case 5://Hiperbola
                    txtConicas.text = "Hiperbola";
                    break;
            }
        }
    }

    public void BtnRecta()
    {
        conicaSeleccionada = 1;
        DibujaConica();
    }

    /*private Vector3[] CreaRecta(float ax, float ay, float bx, float by, int resolucion)
    {
        posPuntos = new Vector3[resolucion];
        float m = (by - ay) / (bx - ax);
        for (int i = 0; i < resolucion; i++)
        {
            float x = ax + (bx - ax) * i / (resolucion - 1);
            float y = ay + (by - ay) * i / (resolucion - 1);
            posPuntos[i] = new Vector3(x, y, 0);
        }
        return posPuntos;
    }*/

    public void BtnCircunferencia()
    {
        conicaSeleccionada = 2;
        DibujaConica();
    }

    public void BtnElipse()
    {
        conicaSeleccionada = 3;
        DibujaConica();
    }

    public void BtnParabola()
    {
        conicaSeleccionada = 4;
        DibujaConica();
    }

    public void BtnHiperbola()
    {
        conicaSeleccionada = 5;
        DibujaConica();
    }
}

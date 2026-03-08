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
            LineRenderer lr = GetComponent<LineRenderer>();
            lr.SetVertexCount(resolucion+1);

            a = sl_a.value;
            b = sl_b.value;
            h = sl_h.value;
            k = sl_k.value;
            t = sl_t.value;

           switch (conicaSeleccionada)
            {
                case 1://Recta
                    txtConicas.text = "Recta"; 
                    lr.material = matRecta;
                    ResetSlidersEtiquetas();
                    lbl_a.text = "ax";
                    lbl_b.text = "ay";
                    lbl_h.text = "bx";
                    lbl_k.text = "by";
                    lbl_t.gameObject.SetActive(false);
                    sl_t.gameObject.SetActive(false);
                    posPuntos = CreaRecta(a, b, h, k, resolucion);
                    break;

                case 2://Circunferencia
                    txtConicas.text = "Circunferencia"; 
                    lr.material = matCircunferencia;
                    ResetSlidersEtiquetas();
                    break;

                case 3://Elipse
                    txtConicas.text = "Elipse";
                    lr.material = matElipse;
                    ResetSlidersEtiquetas();
                    break;

                case 4://Parabola
                    txtConicas.text = "Parábola";
                    lr.material = matParabola;
                    ResetSlidersEtiquetas();
                    break;

                case 5://Hiperbola
                    txtConicas.text = "Hiperbola";
                    lr.material = matHiperbola;
                    ResetSlidersEtiquetas();
                    break;
            }

            for (int i = 0; i <= resolucion; i++ )
            {
                lr.SetPosition(i, posPuntos[i]);
            }
        }
    }

    public void ResetSlidersEtiquetas()
    {
        sl_a.gameObject.SetActive(true);
        sl_b.gameObject.SetActive(true);
        sl_h.gameObject.SetActive(true);
        sl_k.gameObject.SetActive(true);
        sl_t.gameObject.SetActive(true);

        lbl_a.gameObject.SetActive(true);
        lbl_b.gameObject.SetActive(true);
        lbl_h.gameObject.SetActive(true);
        lbl_k.gameObject.SetActive(true);
        lbl_t.gameObject.SetActive(true);

        lbl_a.text = "a";
        lbl_b.text = "b";
        lbl_h.text = "h";
        lbl_k.text = "k";
        lbl_t.text = "t";
    }

    public void BtnRecta()
    {
        conicaSeleccionada = 1;
        DibujaConica();
    }

    private Vector3[] CreaRecta(float ax, float ay, float bx, float by, int resolucion)
    {
        posPuntos = new Vector3[resolucion+1];
        float dx = (bx - ax); 
        float dy = (by - ay);
        for (int i = 0; i <= resolucion; i++)
        {
            posPuntos[i] = new Vector3(ax + dx * i / resolucion, ay + dy * i / resolucion);
        }
        return posPuntos;
    }

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

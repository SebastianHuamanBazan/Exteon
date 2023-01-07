using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class TextoControl : MonoBehaviour
{
    [SerializeField] TestoPlantilla plantilla;
    [SerializeField] TestoPlantilla[] arrayPlantillas;

    [SerializeField] TextMeshProUGUI textoNarracion;
    [SerializeField] TextMeshProUGUI textoRespuestaUno;
    [SerializeField] TextMeshProUGUI textoRespuestaDos;
    

    [SerializeField] GameObject[] arrayBotones;

    public AudioSource myAudioSource;
    public AudioSource myAudioSource2;

    private void Start()
    {
        plantilla = arrayPlantillas[44];
        muestraTexto();
    }

    void muestraTexto()
    {
        textoNarracion.text = plantilla.textoNarrativo;
        textoRespuestaUno.text = plantilla.respuestaUno;
        textoRespuestaDos.text = plantilla.respuestaDos;

        if (plantilla.quitaBotones == true)
        {
            DesactivaBotones();
        }

        else
            foreach (var boton in arrayBotones)
            {
                boton.SetActive(true);
            }


        if (plantilla.quitaBotones1 == true)
        {
            DesactivaBotones1();
        }
        else
            arrayBotones[1].SetActive(true);


        if (plantilla == arrayPlantillas[33])
        {
            myAudioSource.Play();


        }

        if (plantilla == arrayPlantillas[44])
        {
            myAudioSource2.Play();




        }
        else
            myAudioSource2.Pause();








    }

    public void controlBotones(int indice)
    {
        plantilla = arrayPlantillas[plantilla.arrayReferencias[indice]];
       
        muestraTexto();

        

    }

    void DesactivaBotones()
    {
        foreach (var boton in arrayBotones)
        {
            boton.SetActive(false);
        }

    }

    void DesactivaBotones1()
    {
        arrayBotones[1].SetActive(false);

    }
}

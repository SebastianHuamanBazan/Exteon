using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ObjetoTexto")]

public class TestoPlantilla : ScriptableObject
{
    [TextArea(3, 15)]
    public string textoNarrativo;
    
    [Space(20)]
    public string respuestaUno;
    public string respuestaDos;
    

    [Space(20)]
    public int[] arrayReferencias = new int[2];

    [Space(20)]
    public bool quitaBotones;

    [Space(20)]
    public bool quitaBotones1;
    internal string respuestaTres;
}

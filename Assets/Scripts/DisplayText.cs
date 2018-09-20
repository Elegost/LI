using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour {

    public string texte = "J'ai un gros zizi bien poilu";
    public float vitesseDefilement = 1f;

    private int avancementDefilement;

	// Use this for initialization
	void Start () {
        avancementDefilement = 0;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<TextMesh>().text += gererDefilement();
	}

    string gererDefilement(){
        if (avancementDefilement <= texte.Length)
        {
            //TROUVER UN MOYEN DE FAIRE DEFILER TEXTE
            return texte[avancementDefilement++].ToString();
        }
        return "";
    }
}

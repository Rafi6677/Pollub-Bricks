using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

    //pokazanie ilosci pozostalych zyc na laptopie na biurku

    public Ball BScript;
    public GameObject threeLivesQuad;
    public GameObject twoLivesQuad;
    public GameObject oneliveQuad;
    public GameObject zerolivesQuad;

	void Start ()
    {
        threeLivesQuad.SetActive(true);
        twoLivesQuad.SetActive(false);
        oneliveQuad.SetActive(false);
        zerolivesQuad.SetActive(false);
    }
	

	void Update ()
    {
		if(BScript.livesLeft == 3)
        {
            threeLivesQuad.SetActive(true);
            twoLivesQuad.SetActive(false);
            oneliveQuad.SetActive(false);
            zerolivesQuad.SetActive(false);
        }

        if(BScript.livesLeft == 2)
        {
            threeLivesQuad.SetActive(false);
            twoLivesQuad.SetActive(true);
            oneliveQuad.SetActive(false);
            zerolivesQuad.SetActive(false);
        }

        if (BScript.livesLeft == 1)
        {
            threeLivesQuad.SetActive(false);
            twoLivesQuad.SetActive(false);
            oneliveQuad.SetActive(true);
            zerolivesQuad.SetActive(false);
        }


        if (BScript.livesLeft == 0)
        {
            threeLivesQuad.SetActive(false);
            twoLivesQuad.SetActive(false);
            oneliveQuad.SetActive(false);
            zerolivesQuad.SetActive(true);
        }
    }
}

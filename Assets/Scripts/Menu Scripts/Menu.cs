using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Button btnGraj;
    public Button btnOpcje;
    public Button btnZasady;
    public Button btnWyjscie;

	void Start ()
    {
        btnGraj = GetComponent<Button>();
        btnOpcje = GetComponent<Button>();
        btnZasady = GetComponent<Button>();
        btnWyjscie = GetComponent<Button>();
    }
	

    public void nacisnijGraj()
    {
        SceneManager.LoadScene("Test");
    }

    public void nacisnijOpcje()
    {
        SceneManager.LoadScene("Opcje");
    }

    public void nacisnijZasady()
    {
        SceneManager.LoadScene("Zasady");
    }

    public void nacisnijWyjscie()
    {
        Application.Quit();
    }
    
}

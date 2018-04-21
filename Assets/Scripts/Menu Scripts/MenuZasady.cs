using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuZasady : MonoBehaviour {

	public Button BtnWroc;

    void Start()
    {
        BtnWroc = BtnWroc.GetComponent<Button>();
    }
	
    public void nacisnijWroc()
    {
        SceneManager.LoadScene("Menu");
    }
}

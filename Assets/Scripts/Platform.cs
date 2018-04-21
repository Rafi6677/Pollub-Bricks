using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour {

    public float platformSpeed = 0.5f;
    public float maxXPos = 4f;

    //początkowa pozycja platformy
    Vector3 platformPosition = new Vector3(0f, 0.6f, -9f);

    void Update()
    {
        //ruch platformy
        float xPos = platformPosition.x + (Input.GetAxis("Horizontal") * platformSpeed);
        platformPosition = new Vector3(Mathf.Clamp(xPos, -maxXPos, maxXPos), 0.6f, -9f);
        transform.position = platformPosition;
        
        //wyjście do MENU po naciśnięciu klawiszu "Escape"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    public float ballForce = 500f;
    public Transform platform;
    public int livesLeft = 3;
   
    public Canvas ui;

    Rigidbody rb;
    Vector3 ballStartPosition;
    Vector3 platformStartPosition;
    bool gameStarted;

    float actualSpeed;
    public float constantSpeed = 7f;

    void Start ()
    {
        ui.enabled = true;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        gameStarted = false;
        ballStartPosition = transform.position;
        platformStartPosition = platform.position;
    }
	

	
	void Update ()
    {
        //wyrzucenie piłki po naciśnięciu spacji
        if (Input.GetKeyDown(KeyCode.Space) && gameStarted == false)
        {
            ui.enabled = false;
            transform.parent = null;
            gameStarted = true;
            rb.isKinematic = false;

            rb.AddForce(new Vector3(0f, 0f, ballForce));
        }


        fail();
        gameOver();
        if(win() < 1)
        {
            SceneManager.LoadScene("WinScene");
        }
        
    }

    public void decreaseLives()
    {
        //zmniejszenie liczby żyć
        livesLeft--;
    }

    void fail()
    {
        //zrestowanie pozycji piłki gdy gracz nie zdoła jej odbić
        if (transform.position.z < -9.5f /*&& ballsLeft() <= 1*/)
        {
            decreaseLives();
            gameStarted = false;
            rb.isKinematic = true;
            platform.position = platformStartPosition;
            transform.SetParent(platform);
            transform.position = ballStartPosition;
        }
    }

    void gameOver()
    {
        //koniec gry gdy skonczy sie liczba zyc
        if (livesLeft == 0)
        {
            SceneManager.LoadScene("LostScene");
        }
    }

    int win()
    {
        //zliczanie liczby pozostalych 0 i 1
        GameObject[] bricksLeft;

        bricksLeft = GameObject.FindGameObjectsWithTag("Brick");
        return bricksLeft.Length;
    }


    private void OnCollisionEnter(Collision collision)
    {
        //zapewnienie stalej predkosci pilki
        rb.velocity = rb.velocity.normalized * constantSpeed;
    }

}

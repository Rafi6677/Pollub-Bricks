﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro2 : MonoBehaviour {

	IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("Menu");
    }

}

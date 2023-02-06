using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnReplay : MonoBehaviour
{

    private void OnMouseDown()
    {
        SceneManager.LoadScene("StartScene");
    }
}

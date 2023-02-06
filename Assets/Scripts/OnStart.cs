using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnStart : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

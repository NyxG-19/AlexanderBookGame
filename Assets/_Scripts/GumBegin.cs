using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GumBegin : MonoBehaviour
{ 
    public void GumGameScene()
    {
        SceneManager.LoadScene("GumGame");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button Play; 
    void Awake()
    {
           Play.onClick.AddListener(() =>
           {
               SceneManager.LoadScene("The  Game");
           });
    }
}

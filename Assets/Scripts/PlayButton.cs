using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button Play;
    public Animator anim;
    private void Awake()
    {
        SetListeners();
    }

    IEnumerable SetListeners()
    {
        yield return new WaitForSeconds(0.5f);
        Play.onClick.AddListener(() =>
        {
            anim.SetTrigger("press");
            SceneManager.LoadScene("TheGame");
        });
    }
}

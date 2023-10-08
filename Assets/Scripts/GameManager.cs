using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject startMenu;

    private void Start()
    {
        Time.timeScale = 0;
    }
    public void PlayButton()
    {
        startMenu.SetActive(false);
        Time.timeScale = 1;
    }
}

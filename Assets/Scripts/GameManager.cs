using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    bool gameActive = false;
    bool gameHasEnded = false;
    bool win = false;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    void GameOver()
    {

    }

    void Restart()
    {
    }
}

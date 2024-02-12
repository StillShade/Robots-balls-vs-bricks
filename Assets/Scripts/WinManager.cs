using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    private int maxSpawn = 30;
    public int GetMaxSpawn
    {
        get
        {
            if (SaveManager.LoadDayData() <= 15)
            {
                return (SaveManager.LoadDayData() * 2);
            } else
            {
                return maxSpawn;
            }   
        }
    }

    public void CheckIfWin ()
    {
        if (ScoreManager.Instance.m_LevelOfFinalBrick >= GetMaxSpawn)
        {
            GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");
            if (bricks.Length == 0)
            {
                LevelManager.Instance.m_LevelState = LevelManager.LevelState.WIN;
                //EventManager.OnGameWon();  - убрал чтобы не задваивались события - мы вызываем его в LevelManager.LevelState.WIN
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public GameObject[] m_TheDamned;

    private float m_coinsCollected = 0;
    public float coinsCollected { get { return m_coinsCollected; } }

    public enum GameState
    {
        Start,
        Playing,
        GameOver
    };

    private GameState m_GameState;
    public GameState State { get { return m_GameState; } }

    private void Awake()
    {
        m_GameState = GameState.Start;
    }



    // Start is called before the first frame update
    void Start() 
    { }


    // Update is called once per frame
    void Update() 
    { 
        switch (m_GameState)
        {
            case GameState.Start:
                if (Input.GetKeyUp(KeyCode.Return) == true)
                {
                    m_GameState = GameState.Playing;
                }
                

                if (Input.GetKeyUp(KeyCode.Escape))
                {
                    Application.Quit();
                }
                break;
        }
    }




}
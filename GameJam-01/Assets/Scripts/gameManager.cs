using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System;


public class gameManager : MonoBehaviour
{
    public static int points = 0;
    public GameObject enemyObject;
    public static int health = 3;
    public static int currentLevel = 1;
    public static GameObject playerObject;
    public static float timer;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("PlayerCharacter");
    }
    public static void Death()
    {

        points = 0;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public static void Win()
    {
        points = 0;
        gameManager.health = 3;
        SceneManager.LoadScene("Finish");
    }

    public static void DeathMainMenu()
    {
        points = 0;
        SceneManager.LoadScene("MainMenu");
        gameManager.health = 3;
    }
    public static void Damage()
    {
        Debug.Log("player health" + gameManager.health);

        gameManager.health = gameManager.health - 1;
        if (gameManager.health <= 0)
        { 
            DeathMainMenu();
        }
        else
        {
            Death();
        }
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        timer += Time.deltaTime;
    }

    }
    



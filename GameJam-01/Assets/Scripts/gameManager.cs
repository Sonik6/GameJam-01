using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static int points = 0;
    public GameObject enemyObject;
    public static int health = 3;
    public static int currentLevel = 1;
    public static GameObject playerObject;
    public static int coinCount = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("PlayerCharacter");
    }
    public static void Death()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
    public static void nextLevel()
    { 
        coinCount = 0;
        currentLevel++;
        string nextLevelName = "Level" + currentLevel;
        Debug.Log(nextLevelName);
        SceneManager.LoadScene(nextLevelName);
    }
    public static void xd()
    {
        Debug.Log("d");
    }
    public static void DeathMainMenu()
    {
        Scene scene = SceneManager.GetActiveScene();
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
    }

    }
    



using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject enemyObject;
    public static UnityEvent playerDamage;
    public static int health = 3;
    public static GameObject playerObject = GameObject.Find("PlayerCharacter");

    private int healthCheck;

    // Start is called before the first frame update
    void Start()
    {
        UnityEvent playerDamage = new UnityEvent();

        healthCheck = gameManager.health;
    }
    public static void Death()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

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
    private void OnTriggerEnter2D(Collider2D collision)
    { }


    // Update is called once per frame
    void Update()
    {

        playerDamage.AddListener(Damage);
        

    }

    }
    



using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject enemyObject;
    public static UnityEvent playerDamage;
    public static int health = 3;

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
    public static void Damage()
    {
        gameManager.health = gameManager.health - 1;
        Death();
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("health: " + gameManager.health);
        Debug.Log("healthcheck:" + healthCheck);
        playerDamage.AddListener(Damage);
            if (gameManager.health > 0)
            {
                healthCheck = gameManager.health;
                playerObject = GameObject.Find("PlayerCharacter");
                double playerPosY = playerObject.transform.position.y;
                if (playerPosY < -6)
                {
                    gameManager.health = 0;
                }
            }
            if (gameManager.health <= 0)
            {
                healthCheck = gameManager.health;
                SceneManager.LoadScene(sceneName: "MainMenu");
            }
        }

    }
    



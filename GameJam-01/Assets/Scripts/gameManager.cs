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
    UnityEvent playerDamage;
    
    private int healthCheck;

    // Start is called before the first frame update
    void Start()
    {
        
        healthCheck = playerHealth.health;
    }
    public static void Death()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    { }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("health: " + playerHealth.health);
        Debug.Log("healthcheck:" + healthCheck);

            if (playerHealth.health > 0)
            {
                healthCheck = playerHealth.health;
                playerObject = GameObject.Find("PlayerCharacter");
                double playerPosY = playerObject.transform.position.y;
                if (playerPosY < -6)
                {
                    playerHealth.health = 0;
                }
            }
            if (playerHealth.health <= 0)
            {
                healthCheck = playerHealth.health;
                SceneManager.LoadScene(sceneName: "MainMenu");
            }
        }

    }
    



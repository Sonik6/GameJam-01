using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject playerObject;
    public int playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 3;

    }


    // Update is called once per frame
    void Update()
    {
        playerObject = GameObject.Find("PlayerCharacter");
        Debug.Log(playerObject);
        double playerPosY = playerObject.transform.position.y;
        Debug.Log(playerPosY);
        if (playerPosY < -6)
        {
            SceneManager.LoadScene(sceneName: "MainMenu");



        }
    }
}

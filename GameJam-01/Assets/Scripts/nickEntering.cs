using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class nickEntering : MonoBehaviour
{
    public static TMP_InputField nickname;
    public static string nick;
    void Start()
    {
        nickname = GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            {
           nick = nickname.text;
            Debug.Log(nick);
            
            SceneManager.LoadScene("leaderboard");
            }

        
    }
}

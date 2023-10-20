using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class TextMeshProFlash1 : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float flashInterval = 0.5f;  // Time in seconds between each flash
    private bool isTextVisible = true;

    private void Start()
    {
        // Check if the TextMeshProUGUI component is assigned.
        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshProUGUI component not assigned. Please assign it in the Inspector.");
            enabled = false; // Disable this script if the TextMeshProUGUI is not assigned.
            return;
        }

        // Start the flashing coroutine.
        StartCoroutine(FlashText());
    }
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }

    private IEnumerator FlashText()
    {
        while (true)
        {
            // Toggle the visibility of the text.
            isTextVisible = !isTextVisible;

            // Set the text's alpha based on its visibility.
            Color textColor = textMeshPro.color;
            textColor.a = isTextVisible ? 1.0f : 0.0f;
            textMeshPro.color = textColor;

            yield return new WaitForSeconds(flashInterval);
        }
    }
}

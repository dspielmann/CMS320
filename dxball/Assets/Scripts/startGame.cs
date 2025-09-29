using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private Button startButton;

    // Name of the scene to load
    [SerializeField] private string sceneToLoad = "Level1";

    void Start()
    {
        // Find the button by its tag
        GameObject buttonObj = GameObject.FindGameObjectWithTag("startbutton");

        if (buttonObj != null)
        {
            startButton = buttonObj.GetComponent<Button>();

            if (startButton != null)
            {
                startButton.onClick.AddListener(OnStartButtonPressed);
            }
            else
            {
                Debug.LogError("No Button component found on object with tag 'startbutton'");
            }
        }
        else
        {
            Debug.LogError("No GameObject found with tag 'startbutton'");
        }
    }

    void OnStartButtonPressed()
    {
        Debug.Log("Start button pressed! Loading Level1...");
        SceneManager.LoadScene(sceneToLoad);
    }
}

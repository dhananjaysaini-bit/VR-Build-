using UnityEngine;

public class HelloInput : MonoBehaviour
{
    private string userInput = "";

    void Start()
    {
        Debug.Log("Hello, World!");
    }

    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 200, 25), "Enter text:");
        userInput = GUI.TextField(new Rect(20, 50, 200, 25), userInput);

        if (GUI.Button(new Rect(20, 85, 100, 30), "Print"))
        {
            Debug.Log("You typed: " + userInput);
        }
    }
}

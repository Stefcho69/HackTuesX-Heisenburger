using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public GameObject objectPrefab; // Reference to the prefab you want to instantiate

    void Start()
    {
        // Get a reference to the Button component
        Button button = GetComponent<Button>();

        // Add a listener for the button click event
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("Hello there!");
        Vector3 spawnPosition = new Vector3(-27f, 30f, 0f);
        if (objectPrefab != null)
        {
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Prefab reference is null. Cannot instantiate.");
        }

        Destroy(gameObject);
    }
}

using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    // Reference to the game object you want to control

    void Start()
    {
        // You can put any initialization code here
    }

    public void ActivateObj(GameObject objectToControl)
    {
        // Check if the objectToControl is not null to avoid errors
        if (objectToControl != null)
        {
            // Activate the game object
            objectToControl.SetActive(true);

            // You can add additional actions or logic here if needed
        }
        else
        {
            Debug.LogWarning("Object to control is not assigned!");
        }
    }

    public void DeactivateObject(GameObject objectToControl)
    {
        // Check if the objectToControl is not null to avoid errors
        if (objectToControl != null)
        {
            // Deactivate the game object
            objectToControl.SetActive(false);

            // You can add additional actions or logic here if needed
        }
        else
        {
            Debug.LogWarning("Object to control is not assigned!");
        }
    }
}


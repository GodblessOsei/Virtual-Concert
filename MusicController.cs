using UnityEngine;

public class MusicController : MonoBehaviour
{
    // Declare public GameObjects for each music genre.
    public GameObject Afrobeat;
    public GameObject RB; // Use 'RB' instead of 'R&B' to avoid syntax issues.
    public GameObject Rock;
    public GameObject Pop;

    // Declare public GameObject for lights.
    public GameObject Lights;

    // Call this function to play Afrobeat music.
    // It activates the Afrobeat object and deactivates others.
    public void PlayAfrobeat()
    {
        Afrobeat.SetActive(true);
        RB.SetActive(false);
        Rock.SetActive(false);
        Pop.SetActive(false);
    }

    // Call this function to play R&B music.
    // It activates the R&B object and deactivates others.
    public void PlayRB()
    {
        Afrobeat.SetActive(false);
        RB.SetActive(true);
        Rock.SetActive(false);
        Pop.SetActive(false);
    }

    // Call this function to play Rock music.
    // It activates the Rock object and deactivates others.
    public void PlayRock()
    {
        Afrobeat.SetActive(false);
        RB.SetActive(false);
        Rock.SetActive(true);
        Pop.SetActive(false);
    }

    // Call this function to play Pop music.
    // It activates the Pop object and deactivates others.
    public void PlayPop()
    {
        Afrobeat.SetActive(false);
        RB.SetActive(false);
        Rock.SetActive(false);
        Pop.SetActive(true);
    }

    // Toggle the active state of the Lights object.
    public void ToggleLights()
    {
        // If the Lights object is active, deactivate it, and vice versa.
        Lights.SetActive(!Lights.activeSelf);
    }
}

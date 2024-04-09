using System.Collections;
using BNG;
using UnityEngine;

public class VRDoor : MonoBehaviour
{
    public float deadTime = 5.0f;
    private bool isDeadTimeActive = false;
    public SceneLoader sceneLoader; // Reference to your Scene Loader script
    public string sceneToLoad = "LoadScene"; // Set the default scene name in the Inspector


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door") && !isDeadTimeActive)
        {
            HandleDoorAction(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door") && !isDeadTimeActive)
        {
            HandleDoorAction(false);
            StartCoroutine(WaitForDeadTime());

            sceneLoader.LoadScene(sceneToLoad);
        }
    }

    private void HandleDoorAction(bool isOpening)
    {
        if (isOpening)
        {
            // Logic for when the door is opened
            Debug.Log("Door has been opened.");
        }
        else
        {
            // Logic for when the door passes the trigger
            Debug.Log("Door has passed me.");
        }
    }

    IEnumerator WaitForDeadTime()
    {
        isDeadTimeActive = true;
        yield return new WaitForSeconds(deadTime);
        isDeadTimeActive = false;
    }
}

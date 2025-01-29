using PathCreation.Examples;
using UnityEngine;

public class CarCollider : MonoBehaviour
{
    public PathFollower myPathFollower;
    public GameObject levelFailedPanel;
    public GameObject levelCompletedPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            myPathFollower.isFinished = true;
            levelFailedPanel.SetActive(true);
            Debug.Log("Level Failed");
        }

        if (other.CompareTag("EndPoint"))
        {
            myPathFollower.isFinished = true;
            levelCompletedPanel.SetActive(true);
            Debug.Log("Level Completed");
        }
    }
}

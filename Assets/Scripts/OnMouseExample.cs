using UnityEngine;

public class OnMouseExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool isActive = false;
    private void Update()
    {
        if (isActive)
            Debug.Log("IS ACTIVE");
    }

    private void OnMouseDown()
    {
        isActive = true;
    }

    private void OnMouseDrag()
    {
        Debug.Log("ON MOUSE DRAG");
    }

    private void OnMouseUp()
    {
        isActive=false;
    }
}

using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Transform mainCamera;
    public Transform mainPos;
    public Transform settingsPos;
    public float speed = 5f;

    private MonoBehaviour cameraController;

    void Start()
    {
        target = mainPos;

        if (mainCamera != null)
        {
            cameraController = mainCamera.GetComponent("SimpleCameraController") as MonoBehaviour;
        }
    }

    private Transform target;

    void Update()
    {
        if (target != null && mainCamera != null)
        {
            mainCamera.position = Vector3.Lerp(mainCamera.position, target.position, speed * Time.deltaTime);
            mainCamera.rotation = Quaternion.Slerp(mainCamera.rotation, target.rotation, speed * Time.deltaTime);

            if (target == mainPos && Vector3.Distance(mainCamera.position, mainPos.position) < 0.5f)
            {
                if (cameraController != null) cameraController.enabled = true;
            }
        }
    }

    public void MoveToSettings()
    {
        if (cameraController != null) cameraController.enabled = false;
        target = settingsPos;
    }

    public void MoveToMain()
    {
        target = mainPos;
    }
}
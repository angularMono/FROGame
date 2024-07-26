using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public float xSensitivity = 5.0f;
    public float ySensitivity = 5.0f;

    private Transform _transform;

    private Transform _cameraTransform;

    private float _cameraPitch = 0.0f;

    private void Awake()
    {
        _transform = GetComponent<Transform>();

        Camera camera = GetComponentInChildren<Camera>();
       _cameraTransform = camera.GetComponent<Transform>();
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        _transform.Rotate(Vector3.up, mouseX * xSensitivity);


        _cameraPitch += mouseY * ySensitivity;

        _cameraPitch = Mathf.Clamp(_cameraPitch, -60.0f, 6.0f);
 //       if (_cameraPitch > 6.0f)        
  //          _cameraPitch = 6.0f;        
  //      if (_cameraPitch < -60.0f)        
  //          _cameraPitch = -60.0f;        

        Quaternion xRotation = Quaternion.Euler(-_cameraPitch, 0.0f, 0.0f);

        _cameraTransform.localRotation = xRotation;
    }
}

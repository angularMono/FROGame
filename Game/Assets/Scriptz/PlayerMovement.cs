using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.0f;
    private Transform _transform;
    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    void Update()
    {
        float verticalMove = Input.GetAxis("Vertical");
        float horizontalMove = Input.GetAxis("Horizontal");


        Vector3 moveVector = verticalMove * _transform.forward + horizontalMove * _transform.right;
        _transform.position = _transform.position + moveVector * speed * Time.deltaTime;
    }
}

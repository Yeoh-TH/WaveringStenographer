using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed = 2f;

    void Update()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z; 
        transform.position = Vector3.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
    }
}

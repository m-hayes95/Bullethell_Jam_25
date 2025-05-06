using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private bool useDebugMovement = false;

    private void Update()
    {
        if (useDebugMovement) DebugMovement();
    }
    private void DebugMovement()
    {
        if (Input.GetKey(KeyCode.W)) MoveUp();
        if (Input.GetKey(KeyCode.S)) MoveDown();
        if (Input.GetKey(KeyCode.D)) MoveRight();
        if (Input.GetKey(KeyCode.A)) MoveLeft();

        CheckCollisionWithEnvironment();
    }
    private void MoveUp()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
    private void MoveDown()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
    private void MoveLeft()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void MoveRight()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void CheckCollisionWithEnvironment()
    {
        // Shoot out a raycast in the direction we are facing to check for collisions
        GetMoveDirection();
    }

    private Vector3 GetMoveDirection()
    {
        // get which way we are currently facing
        Vector3 moveDir = transform.position;
        Debug.Log($"Move dir = {moveDir}");
        return moveDir;
    }



}

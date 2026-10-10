using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BotMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;

    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        _moveDirection = direction.normalized;
    }

    private void FixedUpdate()
    {
        Vector3 velocity = _moveDirection * _moveSpeed;
        velocity.y = _rigidbody.velocity.y;

        _rigidbody.velocity = velocity;
    }

}
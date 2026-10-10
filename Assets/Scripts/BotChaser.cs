using UnityEngine;

[RequireComponent(typeof(BotMovement))]
public class BotChaser : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _stopDistance = 1.5f;

    private BotMovement _botMovement;

    private void Awake()
    {
        _botMovement = GetComponent<BotMovement>();
    }

    private void Update()
    {
        Vector3 direction = _target.position - transform.position;
        direction.y = 0f;

        if (direction.sqrMagnitude <= _stopDistance * _stopDistance)
        {
            _botMovement.Move(Vector3.zero);
            return;
        }

        _botMovement.Move(direction.normalized);
    }

}
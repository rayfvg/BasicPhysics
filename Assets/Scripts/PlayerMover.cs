using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _torgueValue;
    [SerializeField] private Transform _camera;

    private float _inputPositionY;
    private float _inputPositionX;

    private float _deadZone;

    private Rigidbody _rigitbody;

    private void Awake()
    {
        _rigitbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _inputPositionX = Input.GetAxis("Horizontal");
        _inputPositionY = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        if (_inputPositionY > _deadZone)
            _rigitbody.AddTorque(_camera.right * Mathf.Abs(_inputPositionY) * _speed);
        _rigitbody.AddTorque(_camera.forward * -_inputPositionX * _torgueValue);
    }
}
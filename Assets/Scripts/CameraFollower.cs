using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Rigidbody _playerRigitbody;

    private void LateUpdate()
    {
        transform.position = _target.position;
        if (_playerRigitbody.velocity.magnitude > 0.05f)
        {
            Vector3 horizontalVelocity = new Vector3(_playerRigitbody.velocity.x, 0, _playerRigitbody.velocity.z);
            transform.rotation = Quaternion.LookRotation(horizontalVelocity);
        }
    }
}
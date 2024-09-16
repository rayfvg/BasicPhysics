using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
}

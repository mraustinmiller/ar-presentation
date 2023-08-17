using UnityEngine;

public class DestroyTimeout : MonoBehaviour
{
    /// <summary>
    /// the time in which the object should be destroyed after being instantiated
    /// </summary>
    [SerializeField] float timeout = 1f;

    void Start()
    {
        Invoke("SetDestroy", timeout);
    }

    /// <summary>
    /// Initiates the destroy sequence of the gameObject that this script is added to
    /// </summary>
    void SetDestroy()
    {
        Destroy(gameObject);
    }
}

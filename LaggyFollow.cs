using UnityEngine;

public class LaggyFollow : MonoBehaviour
{
    public Transform target;            // The camera or parent object to follow
    public float followSpeed = 5f;      // Speed at which the object catches up to the target
    public Vector3 offset = new Vector3(-0.5f, -0.5f, 0); // Offset for the position (adjust as needed)

    private Vector3 targetPosition;
    private Quaternion targetRotation;

    void Start()
    {
        if (target != null)
        {
            // Set initial position and rotation based on target
            targetPosition = target.position + offset;
            targetRotation = target.rotation;
        }
    }

    void Update()
    {
        if (target != null)
        {
            // Calculate the target position (in world space)
            targetPosition = target.position + target.rotation * offset;

            // Smoothly move towards the target position (with lag)
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

            // Smoothly rotate towards the target rotation (with lag)
            transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, followSpeed * Time.deltaTime);
        }
    }
}

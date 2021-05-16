using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField] private Transform playerTransform;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position + new Vector3(-1f, 1.2f, 0), 0.06f);
	}
}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;public class Player : MonoBehaviour
{
	[SerializeField] private Rigidbody _rigidbody;
	[SerializeField] private AudioSource audioSource;
	private Vector2 moveDirection;
	private bool isAbleToMove = true;

	void Start()
    {
		_rigidbody.Sleep();
	}

   
	void FixedUpdate()
    {
		if (isAbleToMove)
		{
			moveDirection = new Vector2(Screen.width / 2, Screen.height / 2) - new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			moveDirection *= 0.008f;

			_rigidbody.AddForce(new Vector3
			(
				-moveDirection.y,
				0,
				moveDirection.x
			), ForceMode.Acceleration);
		}
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("PlayerKiller"))
		{
			isAbleToMove = false;
			_rigidbody.Sleep();
			StartCoroutine(PlayerDied());
		}
	}
	private IEnumerator PlayerDied()
	{
			for (float i = 1; i > 0; i -= 0.01f)
			{
				audioSource.pitch = i;
				yield return new WaitForSecondsRealtime(0.02f);
			}
			SceneManager.LoadSceneAsync("Start");
	}
}

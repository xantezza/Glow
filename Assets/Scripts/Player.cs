using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Player : MonoBehaviour
{
	[SerializeField] private Rigidbody _rigidbody;
	private Vector2 moveDirection;
	private bool isAbleToMove = false;


	void Start()
    {
		_rigidbody.Sleep();
	}

    public void Launch()
    {
		isAbleToMove = true;
	}
	void FixedUpdate()
    {
		if (isAbleToMove)
		{
			moveDirection = new Vector2(Screen.width / 2, Screen.height / 2) - new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			moveDirection *= 0.0002f;

			_rigidbody.AddForce(new Vector3
			(
				-moveDirection.y,
				0,
				moveDirection.x
			), ForceMode.Impulse);
		}
	}


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerKiller"))
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
}

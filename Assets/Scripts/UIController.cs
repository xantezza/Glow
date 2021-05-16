using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour
{
    [SerializeField] private Player playerScript;
    [SerializeField] private GameObject button;
	[SerializeField] private AudioSource audioSource;
	public void Launch()
    {
		playerScript.Launch();
		button.SetActive(false);
		audioSource.Play();
	}

	public void PlayerDying()
	{
		StartCoroutine(SomeCoroutine());
		
	}

	private IEnumerator SomeCoroutine()
	{
		for (float i = 1; i > 0; i -= 0.01f)
		{
			audioSource.pitch = i;
			yield return new WaitForSecondsRealtime(0.02f);
		}

	}
}

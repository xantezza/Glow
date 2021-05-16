using UnityEngine;

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
}

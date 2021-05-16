using UnityEngine;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{
	public void Launch()
    {
		SceneManager.LoadSceneAsync("Main");
	}
}

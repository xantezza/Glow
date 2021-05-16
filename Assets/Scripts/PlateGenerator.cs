using UnityEngine;

public class PlateGenerator : MonoBehaviour
{
	[SerializeField] private GameObject platePrefab;
	void Start()
    {
		for (float x = 1; x <100; x++)
        {
			var plate = Instantiate(platePrefab, new Vector3(x, 0, Random.Range(-0.4f,0.4f)), Quaternion.identity);
			plate.transform.parent = this.transform;
		}
	}
}

using UnityEngine;

public class PlateGenerator : MonoBehaviour
{
	[SerializeField] private GameObject platePrefab;
	[SerializeField] private GameObject obstaclePrefab;

	void Start()
    {
		for (float x = 1; x <100; x++)
        {
			var plate = Instantiate(platePrefab, new Vector3(x, 0, Random.Range(-0.3f,0.3f)), Quaternion.identity);
			plate.transform.parent = this.transform;
			if (Random.Range(0, x) > 20)
			{
				var obstacle = Instantiate(obstaclePrefab);
				obstacle.transform.parent = plate.transform;
				obstacle.transform.localPosition = new Vector3(Random.Range(-0.5f, 0.5f), 0.5f, 0);
			}
		}
	}
}

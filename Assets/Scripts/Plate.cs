using UnityEngine;

public class Plate : MonoBehaviour
{
	[SerializeField] private GameObject obstaclePrefab;
	void Start()
	{
		var obstacle = Instantiate(obstaclePrefab);
		obstacle.transform.parent = this.transform;
		obstacle.transform.localPosition = new Vector3(Random.Range(-0.5f, 0.5f), 0.5f, 0);
	}
}

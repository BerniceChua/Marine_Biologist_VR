using UnityEngine;
using System.Collections;

public class RandomMarineLifeSpawner : MonoBehaviour {

	public GameObject[] marineLife;
	public Vector3 spawnValues;
	public float spawnDelay;
	public float spawnMaxDelay;
	public float spawnMinDelay;

	public int startWait;
	public bool stop;

	private int randomMarineLife;

	void Start () {
		StartCoroutine (waitSpawner ());
	}

	void Update () {
		spawnDelay = Random.Range (spawnMinDelay, spawnMaxDelay);
	}

	IEnumerator waitSpawner() {
		yield return new WaitForSeconds (startWait);

		while (!stop) {
			randomMarineLife = Random.Range (0, 4);

			Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x/2, spawnValues.x/2), Random.Range(-spawnValues.y/2, spawnValues.y/2), Random.Range(-spawnValues.z/2, spawnValues.z/2));

			Instantiate (marineLife[randomMarineLife], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);

			yield return new WaitForSeconds (spawnDelay);
		}
	}
}
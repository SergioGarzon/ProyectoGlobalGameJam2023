using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectInScene : MonoBehaviour
{
    [SerializeField] public GameObject[] objectToSpawn;

    [SerializeField] float secondSpawn = 1.5f;

    [SerializeField] float minTras;

    [SerializeField] float maxTras;

    private void Start()
    {
        StartCoroutine(ObstacleSpawn());
    }

    IEnumerator ObstacleSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(objectToSpawn[Random.Range(0, objectToSpawn.Length)], position, Quaternion.identity);

            yield return new WaitForSeconds(secondSpawn);

            Destroy(gameObject, 20f);
        }

    }
}

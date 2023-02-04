using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectRoot : MonoBehaviour
{
    
    public GameObject player;

    public ParticleSystem particle;

    public void SpawnObjectRootScene()
    {
        StartCoroutine(ObstacleSpawn());
    }
    
    IEnumerator ObstacleSpawn()
    {
        while (true)
        {
            Instantiate(particle, new Vector3(player.transform.position.x, player.transform.position.y, 0f), Quaternion.identity); 

            yield return new WaitForSeconds(0.2f);

            Destroy(gameObject, 0.2f);
        }

    }


}

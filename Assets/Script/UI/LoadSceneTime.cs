using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneTime : MonoBehaviour
{
    public float timeStart;
    public float timeEnd;

    public string nameScene;

    public GameObject objectScene;
    private OpenScene sceneChange;

    private void Start()
    {
        sceneChange = objectScene.GetComponent<OpenScene>();
    }

    private void Update()
    {
        timeStart += Time.deltaTime;

        if(timeStart >= timeEnd)
        {
            sceneChange.OpenSceneGame(nameScene);
        }
    }
}

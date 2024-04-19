using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public BossOnPlayer bossTimer;

    private void Start()
    {
        sceneChanger();
    }
    private IEnumerator changeScene()
    {
        yield return new WaitForSeconds(5);
        bossTimer.changeSceneToCorridor();
        yield return new WaitForSeconds(5);
        bossTimer.changeSceneToClassroom();
    }

    public void sceneChanger()
    {
        StartCoroutine(changeScene());
    }


}

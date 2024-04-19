using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
//using PixelCrushers.DialogueSystem;

public class BossOnPlayer : MonoBehaviour
{
    public TeleportPlayerFade teleport;
    public ScreenFader screenFader;
    //public Transform bossTalkPosition;
    //public GameObject boss;
    public GameObject campus, corridor, classroom;

    public CharacterController playerController;

    //public GameObject characterTart;

    //public GameObject[] toHide;
    //public GameObject[] toShow;

    public void changeSceneToCorridor()
    {
        disableController();
        teleport.ResetPlayerPosRotWithParameters(transform, screenFader);
        sceneChanger1();
    }


    public void changeSceneToClassroom()
    {
        disableController();
        teleport.ResetPlayerPosRotWithParameters(transform, screenFader);
        sceneChanger2();
    }

    private IEnumerator changeScene1()
    {
        yield return new WaitForSeconds(0.5f);
        sceneContainer1();
    }

    public void sceneChanger1()
    {
        StartCoroutine(changeScene1());
    }

    private IEnumerator changeScene2()
    {
        yield return new WaitForSeconds(0.5f);
        sceneContainer2();
    }

    public void sceneChanger2()
    {
        StartCoroutine(changeScene2());
    }

    public void sceneContainer1()
    {
        campus.SetActive(false);
        corridor.SetActive(true);
        classroom.SetActive(false);
    }

    public void sceneContainer2()
    {
        campus.SetActive(false);
        corridor.SetActive(false);
        classroom.SetActive(true);
    }


    /*public void talkToBoss()
    {
        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        //StartCoroutine(endConversationAndTeleport());
    }

    public void talkToBossAgain()
    {
        //QuestLog.SetQuestState("Boss_Second", QuestState.Success);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        //StartCoroutine(endConversationAndTeleport());
    }*/

    /*private IEnumerator endConversationAndTeleport()
    {
        yield return new WaitForSeconds(0.5f);
        //talk
        foreach (var item in boss.GetComponents<DialogueSystemTrigger>())
        {
            item.OnUse();
        }
    }*/

    public void enableController()
    {
        playerController.enabled = true;
    }

    public void disableController()
    {
        playerController.enabled = false;
    }

    /*public void talkToBossThird()
    {

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    public void talkToBossFourth()
    {
        QuestLog.SetQuestState("Boss_Third", QuestState.Grantable);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    public void talkToBossFifth()
    {
        disableController();

        //退出点餐，去和boss聊天
        QuestLog.SetQuestState("Boss_Third", QuestState.Success);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    public void TartNPCShow()
    {
        characterTart.SetActive(true);

        StartCoroutine(npcDelayShow());
    }

    public void talkAfterTart()
    {
        QuestLog.SetQuestState("Boss_Fifth", QuestState.Active);


    }

    private IEnumerator npcDelayShow()
    {
        yield return new WaitForSeconds(0.5f);
        //talk
        foreach (var item in characterTart.GetComponents<DialogueSystemTrigger>())
        {
            item.OnUse();
        }
    }

    public void talkToBossSix()
    {
        disableController();

        //给了蛋挞之后
        QuestLog.SetQuestState("Boss_Fifth", QuestState.Active);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());
    }

    public void talkToBossSeven()
    {
        //收工！

        QuestLog.SetQuestState("Boss_Fifth", QuestState.Grantable);

        teleport.ResetPlayerPosRotWithParameters(bossTalkPosition, screenFader);

        StartCoroutine(endConversationAndTeleport());

        foreach (GameObject obj in toHide)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in toShow)
        {
            obj.SetActive(true);
        }

    }*/

}

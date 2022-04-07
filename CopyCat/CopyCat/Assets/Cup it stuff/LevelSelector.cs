using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor; 

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButton;

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1); 

        for (int i = 0; i < levelButton.Length; i++)
        {
            if (i + 1 > levelReached)
                levelButton[i].interactable = false;
        }
    }

    public void ResetAll()
    {
        PlayerPrefs.DeleteAll();
        levelButton[1].interactable = false;
        levelButton[2].interactable = false;
        levelButton[3].interactable = false;
        levelButton[4].interactable = false;
        levelButton[5].interactable = false;
        levelButton[6].interactable = false;
        levelButton[7].interactable = false;
        levelButton[8].interactable = false;
        levelButton[9].interactable = false;
        levelButton[10].interactable = false;
        levelButton[11].interactable = false;
        levelButton[12].interactable = false;
        levelButton[13].interactable = false;
        levelButton[14].interactable = false;
        levelButton[15].interactable = false;
        levelButton[16].interactable = false;
        levelButton[17].interactable = false;
        levelButton[18].interactable = false;
        levelButton[19].interactable = false;
        levelButton[20].interactable = false;
        levelButton[21].interactable = false;
        levelButton[22].interactable = false;
        levelButton[23].interactable = false;
        levelButton[24].interactable = false;
        levelButton[25].interactable = false;
        levelButton[26].interactable = false;
        levelButton[27].interactable = false;
        levelButton[28].interactable = false;
        levelButton[29].interactable = false;
        levelButton[30].interactable = false;
        levelButton[31].interactable = false;
        levelButton[32].interactable = false;
        levelButton[33].interactable = false;
        levelButton[34].interactable = false;
        levelButton[35].interactable = false;
        levelButton[36].interactable = false;
        levelButton[37].interactable = false;
        levelButton[38].interactable = false;
        levelButton[39].interactable = false;
        levelButton[40].interactable = false;
        levelButton[41].interactable = false;
        levelButton[42].interactable = false;
        levelButton[43].interactable = false;
        levelButton[44].interactable = false;
        levelButton[45].interactable = false;
        levelButton[46].interactable = false;
        levelButton[47].interactable = false;
        levelButton[48].interactable = false;
        levelButton[49].interactable = false;

        Debug.Log("Reset All");
    }


    public void ChangeLevel1()
    {
        SceneManager.LoadScene(2); 
    }

    public void ChangeLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void ChangeLevel3()
    {
        SceneManager.LoadScene(4);
    }

    public void ChangeLevel4()
    {
        SceneManager.LoadScene(5);
    }

    public void ChangeLevel5()
    {
        SceneManager.LoadScene(6);
    }

    public void ChangeLevel6()
    {
        SceneManager.LoadScene(7);
    }

    public void ChangeLevel7()
    {
        SceneManager.LoadScene(8);
    }

    public void ChangeLevel8()
    {
        SceneManager.LoadScene(9);
    }

    public void ChangeLevel9()
    {
        SceneManager.LoadScene(10);
    }

    public void ChangeLevel10()
    {
        SceneManager.LoadScene(11);
    }

    public void ChangeLevel11()
    {
        SceneManager.LoadScene(12);
    }

    public void ChangeLevel12()
    {
        SceneManager.LoadScene(13);
    }

    public void ChangeLevel13()
    {
        SceneManager.LoadScene(14);
    }

    public void ChangeLevel14()
    {
        SceneManager.LoadScene(15);
    }

    public void ChangeLevel15()
    {
        SceneManager.LoadScene(16);
    }

    public void ChangeLevel16()
    {
        SceneManager.LoadScene(17);
    }

    public void ChangeLevel17()
    {
        SceneManager.LoadScene(18);
    }

    public void ChangeLevel18()
    {
        SceneManager.LoadScene(19);
    }

    public void ChangeLevel19()
    {
        SceneManager.LoadScene(20);
    }

    public void ChangeLevel20()
    {
        SceneManager.LoadScene(21);
    }
    public void ChangeLevel21()
    {
        SceneManager.LoadScene(22);
    }
    public void ChangeLevel22()
    {
        SceneManager.LoadScene(23);
    }
    public void ChangeLevel23()
    {
        SceneManager.LoadScene(24);
    }
    public void ChangeLevel24()
    {
        SceneManager.LoadScene(25);
    }
    public void ChangeLevel25()
    {
        SceneManager.LoadScene(26);
    }
    public void ChangeLevel26()
    {
        SceneManager.LoadScene(27);
    }
    public void ChangeLevel27()
    {
        SceneManager.LoadScene(28);
    }
    public void ChangeLevel28()
    {
        SceneManager.LoadScene(29);
    }
    public void ChangeLevel29()
    {
        SceneManager.LoadScene(30);
    }
    public void ChangeLevel30()
    {
        SceneManager.LoadScene(31); 
    }
    public void ChangeLevel31()
    {
        SceneManager.LoadScene(32);
    }
    public void ChangeLevel32()
    {
        SceneManager.LoadScene(33);
    }
    public void ChangeLevel33()
    {
        SceneManager.LoadScene(34);
    }
    public void ChangeLevel34()
    {
        SceneManager.LoadScene(35);
    }
    public void ChangeLevel35()
    {
        SceneManager.LoadScene(36);
    }
    public void ChangeLevel36()
    {
        SceneManager.LoadScene(37);
    }
    public void ChangeLevel37()
    {
        SceneManager.LoadScene(38);
    }
    public void ChangeLevel38()
    {
        SceneManager.LoadScene(39);
    }
    public void ChangeLevel39()
    {
        SceneManager.LoadScene(40);
    }
    public void ChangeLevel40()
    {
        SceneManager.LoadScene(41);
    }
    public void ChangeLevel41()
    {
        SceneManager.LoadScene(42);
    }
    public void ChangeLevel42()
    {
        SceneManager.LoadScene(43);
    }
    public void ChangeLevel43()
    {
        SceneManager.LoadScene(44);
    }
    public void ChangeLevel44()
    {
        SceneManager.LoadScene(45);
    }
    public void ChangeLevel45()
    {
        SceneManager.LoadScene(46);
    }
    public void ChangeLevel46()
    {
        SceneManager.LoadScene(47);
    }
    public void ChangeLevel47()
    {
        SceneManager.LoadScene(48);
    }
    public void ChangeLevel48()
    {
        SceneManager.LoadScene(49);
    }
    public void ChangeLevel49()
    {
        SceneManager.LoadScene(50);
    }
    public void ChangeLevel50()
    {
        SceneManager.LoadScene(51);
    }
}

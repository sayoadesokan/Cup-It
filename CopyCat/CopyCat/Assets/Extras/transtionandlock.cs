using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class transtionandlock : MonoBehaviour
{
    public GameObject transition;
    public Button survivalb;
    public Button unlockb;
    public Image lockimg;
    public GameObject sbutton;
    private void Awake()
    {
        transition.gameObject.SetActive(true);
        StartCoroutine(transitongo());
        survivalb.interactable = false;
    }

    void Update()
    {
      if(unlockb.interactable == true)
        {
            survivalb.interactable = true;
            lockimg.gameObject.SetActive(false);
            Destroy(sbutton);
        }  
    }

    IEnumerator transitongo()
    {
        yield return new WaitForSeconds(1f);

        DestroyObject(transition);
    }
}

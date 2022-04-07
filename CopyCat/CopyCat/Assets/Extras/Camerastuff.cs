using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerastuff : MonoBehaviour
{
    public SpriteRenderer targetsize; 

    // Start is called before the first frame update
    void Start()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = targetsize.bounds.size.x / targetsize.bounds.size.y;

        if(screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = targetsize.bounds.size.y / 2;
        }
        else
        {
            float differenceinsize = targetRatio / screenRatio;
            Camera.main.orthographicSize = targetsize.bounds.size.y / 2 * differenceinsize;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

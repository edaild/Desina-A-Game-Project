using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    
    public GameObject nodeLeft;
    public GameObject nodeRight;
    public bool leftBreak = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetRandom()
    {
        int randVal = Random.Range(0, 2);
        if (randVal == 1)
        {
            leftBreak = false;
        }
        else
        {
            leftBreak = true;
        }
    }
    public void IsTouch()
    {
        if (leftBreak == true)
        {
            nodeLeft.SetActive(false);
        }
        else
        {
            nodeRight.SetActive(false);
        }
    }
    public void ResetNode()
    {
        nodeLeft.SetActive(true);
        nodeRight.SetActive(true);
        SetRandom();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") {
            if (leftBreak == false)
            {
                nodeLeft.SetActive(true);
            }
        }
    }
}

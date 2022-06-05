using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken2 : MonoBehaviour
{
    Animator a;
    int timedelay = 1;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isrun = false;
        bool iswalk = false;
        bool iseat = false;
        bool isturnhead = false;
        bool isidle = false;
        int actioncode = 1;
        actioncode = Random.Range(1, 5);
        timedelay = timedelay + 1;
        if (timedelay > 1000)
        {
            timedelay = 1;
            if (actioncode == 1)
            {
                isrun = true;
                
            }
            else if (actioncode == 2)
            {
                iswalk = true;
                
            }
            else if (actioncode == 3)
            {
                iseat = true;
                
            }
            else if (actioncode == 4)
            {
                isturnhead = true;
               
            }
            else if (actioncode == 5)
            {
                isidle = true;
                
            }
            else
            {
                isidle = true;
                
            }
        }


               if (isrun == true)
        {
            a.Play("Run In Place");
        }
        else if (iswalk == true)
        {
            a.Play("Walk In Place");
        }
        else if (iseat == true)
        {
            a.Play("Eat");
        }
        else if (isturnhead == true)
        {
            a.Play("Turn Head");
        }
        else if (isidle == true)
        {
            a.Play("Idle");
        }
        else
        {
            a.Play("Idle");
        }
    }
}

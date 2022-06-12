using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken2 : MonoBehaviour
{
    Animator a;
    int timedelay = 1;
    float x, y, z;
    bool isrun = false;
    bool iswalk = false;
    bool iseat = false;
    bool isturnhead = false;
    bool isidle = false;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        int actioncode = 1;
        timedelay = timedelay + 1;
        if (timedelay > 500)
        {
            actioncode = Random.Range(1, 5);
            timedelay = 1;
            if (actioncode == 1)
            {
                isrun = true;
                iswalk = false;
                iseat = false;
                isturnhead = false;
                isidle = false;
                
            }
            else if (actioncode == 2)
            {
                iswalk = true;
                isrun = false;
                iseat = false;
                isturnhead = false;
                isidle = false;
                
            }
            else if (actioncode == 3)
            {
                iseat = true;
                isrun = false;
                iswalk = false;
                isturnhead = false;
                isidle = false;
                
            }
            else if (actioncode == 4)
            {
                isturnhead = true;
                isrun = false;
                iswalk = false;
                iseat = false;
                isidle = false;
               
            }
            else if (actioncode == 5)
            {
                isidle = true;
                isrun = false;
                iswalk = false;
                iseat = false;
                isturnhead = false;
                
            }
            else
            {
                isidle = true;
                isrun = false;
                iswalk = false;
                iseat = false;
                isturnhead = false;

            }
        }


        if (isrun == true)
        {
            a.Play("Run In Place");
            transform.Translate(x, y, 0.001f);
            
        }
        else if (iswalk == true)
        {
            a.Play("Walk In Place");
            transform.Translate(x, y, 0.001f);
            
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

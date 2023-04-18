using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animation Button;
    public Animation toOpen;
    
    void start()
    {
        button.enable = false;
    }
    
    private void onTriggerEnter(Collider other)
    {
        button.enabled = true;
        toOpen.enabled = true;
    }

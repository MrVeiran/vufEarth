using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flicker : MonoBehaviour
{
    public GameObject objTurnOnOff;
    
    private float _timer=0;
 
    private bool _trigger = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FlickerLight();
    }
    void FlickerLight()
    {
        if(_trigger==false)
        {
            _trigger = true;
            _timer = Random.Range(5, 10);
        }
        if(_timer>0)
        {
            objTurnOnOff.SetActive(true);
        }
        if (_timer < 0)
        {
            objTurnOnOff.SetActive(false);
        }

        if (_timer<-15.0f)
        {
            _trigger = false;
        }
        _timer -= Time.deltaTime;
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlashLight : MonoBehaviour
{
    public bool isOn;
    public Light light; 
    public AudioSource switchsound;
    public float baterypower = 300;
    public float time = 1f;
    public float lowBatteryThreshold = 20f;
    public float fadeDuration = 2f;
    private bool isFading = false;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            
        if(Input.GetKeyDown(KeyCode.E))
        {

            switchsound.Play();
            isOn = !isOn;
            
        }
        
        light.enabled = isOn;
        if(isOn)
        {
            baterypower -= time * Time.deltaTime;
        }
        if(baterypower < 280)
        {
            InvokeRepeating("fade", 1f, 1f);
        }
            
        

    }
    void fade()
    {
       light.intensity -= 1 - baterypower / 300;
    }
    private void OnMouseDown()
    {
        
    }
}

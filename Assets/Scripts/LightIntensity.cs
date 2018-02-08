using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour {
    
    [SerializeField] Light lightLantern;
    float lightIntensity;
    public float lightRange;
    [SerializeField] float lightRemoved;
    [SerializeField] float maxLightRange;
    void Start()
    {
        lightRange = maxLightRange;
    }
    void Update()
    {

        if(lightRange > 0)
        {
            lightRange -= lightRemoved * Time.deltaTime;
        }

        //lt.intensity = lightIntensity;
        lightLantern.range = lightRange;
        if(lightRange > maxLightRange)
        {
            lightRange = maxLightRange;
        }
    }
    public void AddLightRange(float addedLightRange)
    {
        if(addedLightRange > 0 && lightRange < maxLightRange)
        {
            Debug.Log("Lägg på ljus");
            lightRange += addedLightRange;
        }
        if (addedLightRange < 0 && lightRange > 0)
        {
            Debug.Log("Ta bort ljus");
            lightRange += addedLightRange;
        }
        else
            Debug.Log("Redan max ljus nivå eller min ljus nivå.");
    }
    public float GetLightRange()
    {
        return lightRange;
    }
    public void SetLightRange(float takeLight)
    {
        lightRange -= takeLight;
    }
    public float GetMaxLightRange()
    {
        return maxLightRange;
    }
}

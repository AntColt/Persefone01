using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLight : MonoBehaviour {


    [SerializeField] float lightToAdd;
    private void OnTriggerEnter(Collider other)
    {
        /*if(other.tag == "Player" && FindObjectOfType<LightIntensity>().GetComponent<LightIntensity>().GetLightRange()
                 < FindObjectOfType<LightIntensity>().GetComponent<LightIntensity>().GetMaxLightRange() - lightToAdd)
        {
            FindObjectOfType<LightIntensity>().GetComponent<LightIntensity>().AddLightRange(lightToAdd);
            Destroy(gameObject);
        }*/
        if (other.tag == "Player")
        {
            FindObjectOfType<LightIntensity>().GetComponent<LightIntensity>().AddLightRange(lightToAdd);
            Destroy(gameObject);
        }
    }
}

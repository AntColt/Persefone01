using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLight : MonoBehaviour {

	/*void Update () {
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<LightIntensity>().AddLightRange(2);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<LightIntensity>().AddLightRange(-2);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log(GetComponent<LightIntensity>().GetLightRange());
        }
    }*/

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPrefab : MonoBehaviour {

    //public GameObject[] prefab;
    public List<GameObject> map;

    void Start()
    {
        //int prefeb_num = Random.Range(0, map.Count);
        //Instantiate(prefab[prefeb_num], transform.position, transform.rotation);
    }

    public int move = 5;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            int prefeb_num = Random.Range(0, map.Count);
            Instantiate(map[prefeb_num], transform.position, transform.rotation);
            transform.position += Vector3.right * 10;

            map.RemoveAt(prefeb_num);
        }
    }
}

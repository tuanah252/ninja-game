using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public GameObject key;
    private Vector3 screenPoint;

    void Start()
    {
        screenPoint = key.transform.position;
    }
    public void onClick()
    {

        Instantiate(obj, screenPoint, Quaternion.identity);
        obj.transform.rotation = Quaternion.Euler(0, 180, 0);


    }
}

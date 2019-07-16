using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{
    public float camspeed = 20f;
    public float panedge = 10f;
    public float scrollspeed=20;
    public float Panliminx;
    public float Panlimaxx;
    public float Panliminz;
    public float Panlimaxz;
    public float scrollimax=200;
    public float scrollimin = 50;
    
    public GameObject camerapan;
    void Update()
    {
        Vector3 pos =transform.position;
        if (Input.GetKey("w")|| Input.mousePosition.y>Screen.height-panedge)
        {
            pos.x = pos.x+(camspeed * Time.deltaTime);
        }
        if (Input.GetKey("s") || Input.mousePosition.y<=panedge)
        {
            pos.x = pos.x-(camspeed * Time.deltaTime);
        }
        if (Input.GetKey("d") || Input.mousePosition.x > Screen.width - panedge)
        {
            pos.z = pos.z - (camspeed * Time.deltaTime);
            
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panedge)
        {
            pos.z = pos.z + (camspeed * Time.deltaTime);
        }
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollspeed * Time.deltaTime*100f;
        pos.x = Mathf.Clamp(pos.x, -Panliminx, Panlimaxx);
        pos.y = Mathf.Clamp(pos.y, scrollimin, scrollimax);
        pos.z = Mathf.Clamp(pos.z, -Panliminz, Panlimaxz);
        transform.position = pos;
    }
}

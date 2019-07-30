using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_spectram : MonoBehaviour
{
    public AudioSpectrum spectrum;
    public GameObject[] point;

    public GameObject obj;
    private LineRenderer lineRenderer;



    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = obj.GetComponent<LineRenderer>();
        lineRenderer.SetWidth(.1f, .1f);
        lineRenderer.SetColors(Color.white, Color.white);

        point = new GameObject[transform.childCount];
    }

    // Update is called once per frame
    void Update()
    {
      

        for (int i = 0; i < point.Length; i++)
        {
            point[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = point[i].transform.position;
     
            lineRenderer.SetPosition(i, Pos);

            Pos.y = (spectrum.MeanLevels[i]*-120)+10;


            point[i].transform.position = Pos;
        }
    }
}

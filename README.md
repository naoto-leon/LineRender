# LineRender
use LineRenderer

#### LineRenderer覚書き
![rainrender take2](https://user-images.githubusercontent.com/43961147/62193387-9c56de00-b3b2-11e9-9009-a2cb04360b50.gif)
*** 

LineRendererが配列で構成されているという事なので、同じく配列を使った何かと相性が良さそう。  
例はスペクトラムと合わせて心拍数測るやつっぽくしてみた。  



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
      

        for (int i = 1; i < point.Length; i=i+2)
        {
            point[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = point[i].transform.position;
     
            lineRenderer.SetPosition(i, Pos);

         
                Pos.y = (spectrum.MeanLevels[i] * -220) ;           

            point[i].transform.position = Pos;
        }

        for (int i = 0; i < point.Length; i = i + 2)
        {
            point[i] = transform.GetChild(i).gameObject;
            Vector3 Pos = point[i].transform.position;

            lineRenderer.SetPosition(i, Pos);


            Pos.y = (spectrum.MeanLevels[i] * +220) ;

            point[i].transform.position = Pos;
        }
    }
    }

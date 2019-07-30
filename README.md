# LineRender
use LineRenderer

#### LineRenderer覚書き
![linerendergif](https://user-images.githubusercontent.com/43961147/62136317-d2e31900-b31e-11e9-80b7-645941e517d5.gif)
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
        //lineRendererの設定
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
            //lineRenderer.SetPosition(配列, ポジション);

            Pos.y = (spectrum.MeanLevels[i]*-120)+10;


            point[i].transform.position = Pos;
        }
    }
    }

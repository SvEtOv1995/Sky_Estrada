using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cordin : MonoBehaviour
{
    public Vector3 v3;

    [SerializeField] private Text text1;
    [SerializeField] private Text text2;
    [SerializeField] private Text text3;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       v3= this.transform.position; 

        text1.text = v3.x.ToString();
        text2.text = v3.y.ToString();
        text3.text = v3.z.ToString();
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text m_Text;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("3353368");
    }

    // Update is called once per frame
    void Update()
    {
        if (Advertisement.IsReady())
        {
            m_Text.text = "OK";
        }
        else
        {
            m_Text.text = "Wait...";
        }
    }

    //显示广告
    public void ShowAdv()
    {
        if (Advertisement.isShowing == false)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show();
            }
        }
    }
}

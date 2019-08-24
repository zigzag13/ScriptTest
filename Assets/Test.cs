using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int mp = 53;

    public void Magic()
    {

        if (mp >= 5)
        {
            this.mp -= 5;

            Debug.Log("魔法攻撃をした。残りＭＰは" + mp);
        }
        else
        {
            Debug.Log("ＭＰが足りないため魔法が使えない。");
        }
    }

}


public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {



        Boss lastboss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeColor : MonoBehaviour
{
    public int selectedcube = -1;
	public int cubenumber = -1;
	public int groupnumber = -1;
    private int dayoftheweek;

    // Use this for initialization
    private void Start() {

    }

    // Update is called once per frame
    private void Update()
    {
		ColorData cols = new ColorData();


		cubenumber++;
        GameObject o = GameObject.Find("Cube" + cubenumber);
		if (o == null)
		{
			cubenumber = 0;
			o = GameObject.Find("Cube" + cubenumber);
		}
        o.GetComponent<Renderer>().material.color = cols.GetAColorToUse(cubenumber);
        if (Input.GetButtonDown("Jump"))
            set_scale_of_cubes();



		/*
		groupnumber++;
		cubenumber++;
		GameObject o = GameObject.Find ("Cubes" + groupnumber + "/Cube" + cubenumber);
		o.GetComponent<Renderer>().material.color = cols.GetAColorToUse(cubenumber);
		if (Input.GetButtonDown("Jump"))
			set_scale_of_cubes();

*/



    }

    private void set_scale_of_cubes()
    {
        GameObject o;
        if (selectedcube > -1)
        {
            o = GameObject.Find("Cube" + selectedcube);
            o.transform.localScale = new Vector3(1, 1, 1);
        }
        selectedcube++;
        o = GameObject.Find("Cube" + selectedcube);
		if (o == null) 
		{
			selectedcube = 0;
			o = GameObject.Find("Cube" + selectedcube);
		}
        o.transform.localScale = new Vector3(1, 2, 1);
    }

    public float yOfCube(int cubeNumber)
    {
		GameObject ob = GameObject.Find ("Cube" + selectedcube);
		return ob.transform.localScale.y;
    }
}

public class ColorData
{
    public Color GetAColorToUse(int indexOfTheColorToGet) {
        List<Color> color_list = new List<Color>();
        color_list.Add(new Color(1, 0, 0));
        color_list.Add(new Color(.7f, .7f, 0));
        color_list.Add(new Color(0, 1, 0));
        color_list.Add(new Color(0, .3f, 1));
        color_list.Add(new Color(0, 1, 1));
        return color_list[indexOfTheColorToGet];
    }
}

public class CubeData
{
    // When we find a cube, we should put its data in here for tidier access
}

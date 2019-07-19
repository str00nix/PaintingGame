using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotScipt2 : MonoBehaviour
{
	public Transform baseDot;
	public KeyCode mouseLeft;
	public static string toolType;
	public Vector3 mousePosition;
	public Vector3 objPosition;
	[SerializeField] Vector2 pos;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 5);
		objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		//objPosition = Mathf.Clamp(Camera.main.ScreenToWorldPoint (mousePosition), new Vector3());
		
		if(Input.GetKey(mouseLeft)){
			Instantiate(baseDot,objPosition,baseDot.rotation);
			}
			
			
			
    }
}

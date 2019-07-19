using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotScriptOnMouse : MonoBehaviour
{
	public Transform baseDot;
	public Vector3 mousePosition;
	public Vector3 objPosition;
	
	public float moveSpeed = 0.1f;
	
	public Renderer rend;
	
	
    // Start is called before the first frame update
    void Start()
    {
		rend = GetComponent<Renderer>();
		
        Instantiate(baseDot,objPosition,baseDot.rotation);
		//baseDot.material.color = Color(0.777, 08, 0.604);
		
		transform.position.z = 5;
    }

    // Update is called once per frame
    void Update()
    {
		mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 5);
		objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		
		/*mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);*/
		
		//baseDot.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		
        //transform.position = Input.mousePosition;
		
		/*if(Input.GetButtonUp("Fire1")){
		rend.material.SetColor("_Color",Random.ColorHSV());*/
		}
    }
}

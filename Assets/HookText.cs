using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HookText : MonoBehaviour

{
    public GameObject body;
    public Text t_left;
    public Text t_right;
    public Text t_hook;
    public Text t_jump;
    public Text t_jump_2;
    public Text t_ladder;
    public Text t_crouch;
    public bool e_pressed = false;
    public bool w_pressed = false;


    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("ladder1");
        if (w_pressed == false && other.transform.name == "Square")
        {
            //Debug.Log("ladder");
            float body_x = body.transform.position.x;
            float body_y = body.transform.position.y;


            t_ladder.transform.position = new Vector3(body_x, body_y + 1.3f, 1);

            t_ladder.text = "Press W / S to climb ladder";
            //t_hook.fontSize = 10;
            t_ladder.GetComponent<Text>().color = Color.white;

            t_ladder.gameObject.SetActive(true);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(e_pressed == false && other.transform.name == "first_collide")
        {
            float body_x = body.transform.position.x;
            float body_y = body.transform.position.y;
            
        
            t_hook.transform.position = new Vector3(body_x+1, body_y+1.5f, 1);
        
            t_hook.text = "Move the mouse to where you want to grapple hook and Press E";
            //t_hook.fontSize = 10;
            t_hook.GetComponent<Text>().color = Color.white;
        
            t_hook.gameObject.SetActive(true);
        }
        

    }

    



    // Start is called before the first frame update
    void Start()
    {
        t_left = GameObject.Find("Text (left)").GetComponent<Text>();
        t_right = GameObject.Find("Text (right)").GetComponent<Text>();
        t_jump = GameObject.Find("Text (jump)").GetComponent<Text>();
        t_jump_2 = GameObject.Find("Text (double jump)").GetComponent<Text>();
        t_hook = GameObject.Find("Text (hook)").GetComponent<Text>();
        t_ladder = GameObject.Find("Text (ladder)").GetComponent<Text>();
        t_crouch = GameObject.Find("Text (crouch)").GetComponent<Text>();

        t_left.gameObject.SetActive(false);
        t_right.gameObject.SetActive(false);
        t_jump.gameObject.SetActive(false);
        t_jump_2.gameObject.SetActive(false);
        t_crouch.gameObject.SetActive(false);

        t_left.text = "Press A to move left";
        t_right.text = "Press D to move right";
        t_jump.text = "Press space to jump";
        t_jump_2.text = "Press space twice for double jump!";
        t_crouch.text = "Press S to crouch";

        t_hook.text = "";
        t_ladder.text = "";
        t_left.GetComponent<Text>().color = Color.white;
        t_right.GetComponent<Text>().color = Color.white;
        t_jump.GetComponent<Text>().color = Color.white;
        t_jump_2.GetComponent<Text>().color = Color.white;
        t_crouch.GetComponent<Text>().color = Color.white;


        float body_x = body.transform.position.x;
        float body_y = body.transform.position.y;
        
        t_left.transform.position = new Vector3(body_x, body_y - 1.5f, 1);
        t_right.transform.position = new Vector3(body_x, body_y+1f, 1);
        t_crouch.transform.position = new Vector3(body_x, body_y + 1.5f, 1);
        t_jump.transform.position = new Vector3(body_x, body_y - 2.2f, 1);
        t_jump_2.transform.position = new Vector3(body_x, body_y - 2.7f, 1);

        t_left.gameObject.SetActive(true);
        t_right.gameObject.SetActive(true);
        t_jump.gameObject.SetActive(true);
        t_jump_2.gameObject.SetActive(true);
        t_crouch.gameObject.SetActive(true);








    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKey(KeyCode.A))
        {
            t_left.gameObject.SetActive(false);
            
        }
        if (Input.GetKey(KeyCode.D)){
            t_right.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            t_crouch.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            t_jump.gameObject.SetActive(false);
            t_jump_2.gameObject.SetActive(false);

        }


        if (Input.GetKey(KeyCode.E))
        {
            e_pressed = true;
            t_hook.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            w_pressed = true;
            t_ladder.gameObject.SetActive(false);
        }


    }
}

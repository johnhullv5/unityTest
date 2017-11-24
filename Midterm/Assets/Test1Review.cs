using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1Review : MonoBehaviour {

    public bool chasing;// = false;
    public bool invading;// = false;
    Vector2 a2, b2, c2;

    Vector3 a3, b3, c3;

    GameObject enemy, player;

    float enemyMaxSpeed = 5f;
    // Use this for initialization
    void Start () {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Player");

       

        a3 = new Vector3(1, 2, 3);

        b3 = new Vector3(2, 3, 4);

        a3 = enemy.transform.position;
        b3 = player.transform.position;
        c3 = a3 + b3;

        print(a3);
        print(b3);
        print(c3);

        c3 = a3 - b3;
        print("a3 - b3 =" + c3);

        c3 = 5 * a3;
        print("5 * a3 =" + c3);

        float a3_magnitute = a3.magnitude;
        float b3_magnitute = b3.magnitude;
        print("a3.magnitude" + a3_magnitute);
        print("b3.magnitude" + b3_magnitute);

       










    }

    // Update is called once per frame
    void Update () {
        print("******************************************************************************************************************************");

        float a3_dot_b3 = Vector3.Dot(a3, b3);
        print("a3_dot_b3 = " + a3_dot_b3);
        Vector3 chaseDirection = (b3 - a3).normalized;

        a3 = enemy.transform.position;
        b3 = player.transform.position;


        bool a3_faces_b3 = Vector3.Dot(chaseDirection, enemy.transform.forward) > 0;
        bool a3_normal_b3 = Mathf.Abs(Vector3.Dot(a3.normalized, b3.normalized)) < 0.00001;
        bool a3_notsee_b3 = !a3_faces_b3;

        print("a3_faces_b3 = " + a3_faces_b3);
        print("a3_normal_b3 = " + a3_normal_b3);
        print("a3_notsee_b3 = " + a3_notsee_b3);

        if (chasing && a3_faces_b3)
        {


            enemy.transform.position += chaseDirection * enemyMaxSpeed * Time.deltaTime;


        }
         if(invading && !a3_faces_b3)
        {
            enemy.transform.position -= chaseDirection * enemyMaxSpeed * Time.deltaTime;

        }

    }


    private void OnDrawGizmos()
    {
        /*
        Gizmos.color = Color.blue;
        Ray r_e = new Ray(a3, enemy.transform.forward);
        Ray r_p = new Ray(b3, player.transform.forward);
        Gizmos.DrawRay(r_e);
        Gizmos.DrawRay(r_p);*/
    }
}

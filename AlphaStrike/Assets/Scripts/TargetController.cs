using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameObject target1 = GameObject.Find ("covidTarget (1)");
    public GameObject target2 = GameObject.Find ("covidTarget (2)");
    public GameObject target3 = GameObject.Find ("covidTarget (3)");
    public GameObject target4 = GameObject.Find ("covidTarget (4)");
    public GameObject target5 = GameObject.Find ("covidTarget (5)");
    public GameObject target6 = GameObject.Find ("covidTarget (6)");
    public GameObject target7 = GameObject.Find ("covidTarget (7)");
    public GameObject target8 = GameObject.Find ("covidTarget (8)");
    public GameObject target9 = GameObject.Find ("covidTarget (9)");
    public GameObject target10 = GameObject.Find ("covidTarget (10)");
    public GameObject target11 = GameObject.Find ("covidTarget (11)");
    public GameObject target12 = GameObject.Find ("covidTarget (12)");
    public GameObject target13 = GameObject.Find ("covidTarget (13)");
    public GameObject target14 = GameObject.Find ("covidTarget (14)");
    public GameObject target15 = GameObject.Find ("covidTarget (15)");
    public GameObject target16 = GameObject.Find ("covidTarget (16)");
    public GameObject target17 = GameObject.Find ("covidTarget (17)");
    public GameObject target18 = GameObject.Find ("covidTarget (18)");
    public GameObject target19 = GameObject.Find ("covidTarget (19)");
    public GameObject target20 = GameObject.Find ("covidTarget (20)");
    public GameObject target21 = GameObject.Find ("covidTarget (21)");
    public GameObject target22 = GameObject.Find ("covidTarget (22)");
    public GameObject target23 = GameObject.Find ("covidTarget (23)");
    public GameObject target24 = GameObject.Find ("covidTarget (24)");
    public GameObject target25 = GameObject.Find ("covidTarget (25)");
    public GameObject target26 = GameObject.Find ("covidTarget (26)");
    public GameObject target27 = GameObject.Find ("covidTarget (27)");
    public GameObject target28 = GameObject.Find ("covidTarget (28)");
    public GameObject target29 = GameObject.Find ("covidTarget (29)");
    public GameObject target30 = GameObject.Find ("covidTarget (30)");
    public GameObject target31 = GameObject.Find ("covidTarget (31)");
    public GameObject target32 = GameObject.Find ("covidTarget (32)");
    public GameObject target33 = GameObject.Find ("covidTarget (33)");
    public GameObject target34 = GameObject.Find ("covidTarget (34)");
    public GameObject target35 = GameObject.Find ("covidTarget (35)");
    public GameObject target36 = GameObject.Find ("covidTarget (36)");
    public GameObject target37 = GameObject.Find ("covidTarget (37)");
    public GameObject target38 = GameObject.Find ("covidTarget (38)");
    public GameObject target39 = GameObject.Find ("covidTarget (39)");
    public GameObject target40 = GameObject.Find ("covidTarget (40)");
    public GameObject target41 = GameObject.Find ("covidTarget (41)");
    public GameObject target42 = GameObject.Find ("covidTarget (42)");
    public GameObject target43 = GameObject.Find ("covidTarget (43)");
    public GameObject target44 = GameObject.Find ("covidTarget (44)");
    public GameObject target45 = GameObject.Find ("covidTarget (45)");

    public const int _MIN = 1;
    public const int _MAX = 46;


    public float Timer = 2f;

    public CountdownController c_ctdown;

    // Start is called before the first frame update
    void Start()
    {
        ResetAllTargets();
    }

    // Update is called once per frame
    void Update()
    {
        if(c_ctdown.countdownTime == 0 && c_ctdown.gameTimer > 0)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0f)
            {
                SpawnTarget();
                Timer = 0.5f;
            }
        }
        if(c_ctdown.gameTimer == 0)
        {
            ResetAllTargets();
        }
    }

    public void SpawnTarget()
    {
        GameObject.Find ("covidTarget (" + Random.Range(_MIN, _MAX) + ")").transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }

    public void ResetAllTargets()
    {
        target1.transform.localScale = new Vector3(0, 0, 0);
        target2.transform.localScale = new Vector3(0, 0, 0);
        target3.transform.localScale = new Vector3(0, 0, 0);
        target4.transform.localScale = new Vector3(0, 0, 0);
        target5.transform.localScale = new Vector3(0, 0, 0);
        target6.transform.localScale = new Vector3(0, 0, 0);
        target7.transform.localScale = new Vector3(0, 0, 0);
        target8.transform.localScale = new Vector3(0, 0, 0);
        target9.transform.localScale = new Vector3(0, 0, 0);
        target10.transform.localScale = new Vector3(0, 0, 0);
        target11.transform.localScale = new Vector3(0, 0, 0);
        target12.transform.localScale = new Vector3(0, 0, 0);
        target13.transform.localScale = new Vector3(0, 0, 0);
        target14.transform.localScale = new Vector3(0, 0, 0);
        target15.transform.localScale = new Vector3(0, 0, 0);
        target16.transform.localScale = new Vector3(0, 0, 0);
        target17.transform.localScale = new Vector3(0, 0, 0);
        target18.transform.localScale = new Vector3(0, 0, 0);
        target19.transform.localScale = new Vector3(0, 0, 0);
        target20.transform.localScale = new Vector3(0, 0, 0);
        target21.transform.localScale = new Vector3(0, 0, 0);
        target22.transform.localScale = new Vector3(0, 0, 0);
        target23.transform.localScale = new Vector3(0, 0, 0);
        target24.transform.localScale = new Vector3(0, 0, 0);
        target25.transform.localScale = new Vector3(0, 0, 0);
        target26.transform.localScale = new Vector3(0, 0, 0);
        target27.transform.localScale = new Vector3(0, 0, 0);
        target28.transform.localScale = new Vector3(0, 0, 0);
        target29.transform.localScale = new Vector3(0, 0, 0);
        target30.transform.localScale = new Vector3(0, 0, 0);
        target31.transform.localScale = new Vector3(0, 0, 0);
        target32.transform.localScale = new Vector3(0, 0, 0);
        target33.transform.localScale = new Vector3(0, 0, 0);
        target34.transform.localScale = new Vector3(0, 0, 0);
        target35.transform.localScale = new Vector3(0, 0, 0);
        target36.transform.localScale = new Vector3(0, 0, 0);
        target37.transform.localScale = new Vector3(0, 0, 0);
        target38.transform.localScale = new Vector3(0, 0, 0);
        target39.transform.localScale = new Vector3(0, 0, 0);
        target40.transform.localScale = new Vector3(0, 0, 0);
        target41.transform.localScale = new Vector3(0, 0, 0);
        target42.transform.localScale = new Vector3(0, 0, 0);
        target43.transform.localScale = new Vector3(0, 0, 0);
        target44.transform.localScale = new Vector3(0, 0, 0);
        target45.transform.localScale = new Vector3(0, 0, 0);
    }

}

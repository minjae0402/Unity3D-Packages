using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Assertions.Comparers;
using UnityEngine.UIElements;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] LayerMask layer;
    [SerializeField] float radius;
    [SerializeField] Collider[] col;
    [SerializeField] Transform target;
    [SerializeField] GameObject mark;
    [SerializeField] float reapet_time;

    [Header("총알")]
    [SerializeField] GameObject ball;
    [SerializeField] Transform StartPosition;
    [SerializeField] float ball_speed;
    [SerializeField] float differ_angle;
    [SerializeField] float curtime;
    [SerializeField] float max_time;

    void Start()
    {
        InvokeRepeating("enemyaround", 0, 0.2f);
        curtime = max_time;
    }
    void Update()
    {
        if (target == null)
        {
            player.transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
        }
        else
        {
            Quaternion dir = Quaternion.LookRotation(target.position - player.transform.position);

            Vector3 angle = Quaternion.RotateTowards(player.transform.rotation, dir, 200 * Time.deltaTime).eulerAngles;

            player.transform.rotation = Quaternion.Euler(0, angle.y, 0);

            Quaternion d_angle = Quaternion.Euler(0, dir.eulerAngles.y, 0);

            if (Quaternion.Angle(player.transform.rotation, d_angle) < differ_angle)
            {
                curtime -= Time.deltaTime;
                if (curtime <= 0)
                {
                    var a = Instantiate(ball, StartPosition.position, StartPosition.rotation);
                    a.GetComponent<Rigidbody>().AddForce(StartPosition.transform.forward * ball_speed);
                    Destroy(a.gameObject, 2.0f);
                    curtime = max_time;
                }
            }
        }
    }

    void enemyaround()
    {
        col = Physics.OverlapSphere(player.transform.position, radius, layer);

        Transform short_enemy = null;

        if (col.Length > 0)
        {
            float short_distance = Mathf.Infinity;

            foreach (Collider s_col in col)
            {
                float playertoenemy = Vector3.SqrMagnitude(player.transform.position - s_col.transform.position);

                if (short_distance > playertoenemy)
                {
                    short_distance = playertoenemy;
                    short_enemy = s_col.transform;
                }
            }
        }
        target = short_enemy;

        if (target != null)
        {
            var v_mark = Instantiate(mark, target);
            Destroy(v_mark.gameObject, reapet_time);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castmain : MonoBehaviour
{

    public GameObject capsuleMesh;

    void OnDrawGizmos()
    {
        RaycastHit hit;
        float rayLength = 20.0f;

        Mesh cm = capsuleMesh.GetComponent<MeshFilter>().sharedMesh;

        Vector3 pos = this.transform.position;
        Vector3 rayPos = pos + new Vector3(3, 0, 3);
        Vector3 cubePos = pos + new Vector3(3, 0, -3);
        Vector3 spherePos = pos + new Vector3(-3, 0, 3);
        Vector3 capsulePos = pos + new Vector3(-3, 0, -3);

        if (Physics.Raycast(rayPos, Vector3.down, out hit, rayLength))
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(rayPos, Vector3.down * hit.distance);

            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(hit.point, 0.1f);
        }


        Vector3 boxSize = new Vector3(1, 1, 1);
        if (Physics.BoxCast(cubePos, boxSize / 2, Vector3.down, out hit, Quaternion.identity, rayLength))
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(cubePos, Vector3.down * hit.distance);

            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(cubePos + Vector3.down * hit.distance, boxSize);

            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(hit.point, 0.1f);
        }


        float radius = 0.5f;
        if (Physics.SphereCast(spherePos, radius, Vector3.down, out hit, rayLength))
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(spherePos, Vector3.down * hit.distance);

            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(spherePos + Vector3.down * hit.distance, radius);

            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(hit.point, 0.1f);
        }


        Vector3 p1 = capsulePos + Vector3.left / 2;
        Vector3 p2 = capsulePos + Vector3.right / 2;
        float capRadius = 0.5f;
        if (Physics.CapsuleCast(p1, p2, capRadius, Vector3.down, out hit, rayLength))
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(capsulePos, Vector3.down * hit.distance);

            Gizmos.color = Color.green;
            Gizmos.DrawWireMesh(cm, 0, capsulePos + Vector3.down * hit.distance, Quaternion.Euler(new Vector3(90, 0, 0)));

            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(hit.point, 0.1f);
        }
    }
}
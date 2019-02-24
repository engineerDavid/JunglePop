using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    // Use this for initialization
    public Transform mHandMesh;
    

    private void Update()
    {
        //helps make sure that the player does not see the mesh
        //for testing it will be used
        //after that then it will be taken off and set to false
        //to activate hand mesh delete                                         mHandMesh.gameObject.SetActive(false);

        //mHandMesh.gameObject.SetActive(false);
        mHandMesh.position = Vector3.Lerp(mHandMesh.position, transform.position, Time.deltaTime * 15.0f);
        
        


    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Bubble"))
            return;




        //sets it to false then sets it to postion 0,0,0 , but still moves
        collision.gameObject.SetActive(false);


        ScoreScript.scoreValue += 10;









    }


}

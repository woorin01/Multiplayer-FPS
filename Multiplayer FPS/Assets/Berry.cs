using UnityEngine;
using System.Collections;

public class Berry : Fruit
{
    public Berry()
    {
        //Debug.Log("1st Apple Constructor Called");
    }

    public override void Move()
    {
        Debug.Log("Berry move!");
    }

    public new void HideMethod()
    {
        Debug.Log("짭탱베리");
    }
}
//apple, mango, berry, etc
//apple, mango is same move
//but berry, etc have diffrent move
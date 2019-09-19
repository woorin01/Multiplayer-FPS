using UnityEngine;
using System.Collections;

public class Apple : Fruit
{
    public Apple()
    {
        //Debug.Log("1st Apple Constructor Called");
    }

    public new void HideMethod()
    {
        Debug.Log("짭탱사과");
        
    }
}
//apple, mango, berry, etc
//apple, mango is same move
//but berry, etc have diffrent move
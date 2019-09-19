using UnityEngine;
using System.Collections;

public class Fruit
{
    public Fruit()
    {
        //Debug.Log("1st Fruit Constructor Called");
    }

    public virtual void Move()
    {
        Debug.Log("Basic move!");
    }

    public void Same()
    {
        Debug.Log("All the same");
    }

    public void HideMethod()
    {
        Debug.Log("원조");
    }
}
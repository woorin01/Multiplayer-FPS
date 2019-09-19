using UnityEngine;
public static class MyExtensionMethods
{
    public static int MyDoublePlus(this int i, int x)
    {
        return i + x;
    }

    public static bool MyStringParase(this string i)
    {
        float b;
        return float.TryParse(i, out b);
        
    }

    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }

    public static T GetT<T>(this T t) //where T : struct
    {
        return t;
    }
}
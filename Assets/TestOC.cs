using UnityEngine;
using System.Collections;

public class TestOC : MonoBehaviour
{
    void Update()
    {
        print(OgettoContrare.GetObjectStatus("Bomb")+" bomb(s)");
        print(OgettoContrare.GetObjectStatus("Bullet") + " bullet(s)");
    }
}

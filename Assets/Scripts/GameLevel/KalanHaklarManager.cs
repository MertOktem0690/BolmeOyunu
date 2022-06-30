using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KalanHaklarManager : MonoBehaviour
{
    [SerializeField]
    private GameObject kalanHaklar1, kalanHaklar2, kalanHaklar3;

    // Start is called before the first frame update
    void Start ( )
    {

    }

    // Update is called once per frame
    void Update ( )
    {

    }

    public void KalanHaklariKontrolEt ( int kalanHak )
    {
        switch ( kalanHak )
        {
            case 3:
                kalanHaklar1.SetActive( true );
                kalanHaklar2.SetActive( true );
                kalanHaklar3.SetActive( true );
                break;

            case 2:
                kalanHaklar1.SetActive( true );
                kalanHaklar2.SetActive( true );
                kalanHaklar3.SetActive( false );
                break;

            case 1:
                kalanHaklar1.SetActive( true );
                kalanHaklar2.SetActive( false );
                kalanHaklar3.SetActive( false );
                break;

            case 0:
                kalanHaklar1.SetActive( false );
                kalanHaklar2.SetActive( false );
                kalanHaklar3.SetActive( false );
                break;

        }
    }
}

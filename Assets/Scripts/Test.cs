using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Test : MonoBehaviour
{
    SimplePostProcessingStackController m_Controller;

    void Start ()
    {
        m_Controller = FindObjectOfType<SimplePostProcessingStackController>();
        Assert.IsNotNull( m_Controller );
    }

    void OnGUI()
    {
        int x = 200;
        int y = 200;

        int profile_num = m_Controller.GetProfileNum();
        for ( int index = 0; index < profile_num; ++ index )
        {
            string label = m_Controller.GetProfileName( index );
            if ( GUI.Button( new Rect( x, y, 200, 100 ), label ) )
            {
                m_Controller.SetProfileIndex( index );
            }

            y += 125;
        }
    }
}

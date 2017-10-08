using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.PostProcessing;

public class SimplePostProcessingStackController : MonoBehaviour
{
    Camera                         m_Camera;
    PostProcessingBehaviour        m_PostProcessingBehaviour;
    public PostProcessingProfile[] m_ProfileArray;
    int                            m_ProfileIndex = 0;

    void Start ()
    {
        m_Camera = Camera.main;
        Assert.IsNotNull( m_Camera );

        m_PostProcessingBehaviour = m_Camera.GetComponent<PostProcessingBehaviour>();
        Assert.IsNotNull( m_PostProcessingBehaviour );
    }


    public void SetProfileIndex( int index )
    {
        PostProcessingProfile profile     = m_ProfileArray[ index ];
        m_PostProcessingBehaviour.profile = profile;
        m_ProfileIndex                    = index;
    }


    public int GetProfileIndex()
    {
         return m_ProfileIndex;
    }

    public int GetProfileNum()
    {
        if ( m_ProfileArray != null )
        {
            return m_ProfileArray.Length;
        }
        else
        {
            return 0;
        }
    }

    public string GetProfileName( int index )
    {
        PostProcessingProfile profile = m_ProfileArray[ index ];
        return profile.name;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{

    // �I�����ꂽ�J�[�hID���X�g
    public List<int> SelectedCardIdList = new List<int>();

    // �V���O���g���̐���
    private static GameStateController mInstance;

    public static GameStateController Instance
    {
        get
        {
            // �C���X�^���X����������Ă��Ȃ��ꍇ�A�����Ő�������
            if (mInstance == null)
            {
                GameObject obj = new GameObject("GameStateController");
                mInstance = obj.AddComponent<GameStateController>();
            }
            return mInstance;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static CardCreateManager;

public class Card : MonoBehaviour
{
    // �J�[�h��ID
    public int Id;

    // �\������J�[�h�̉摜
    public Image CardImage;

    // �I������Ă��邩����
    private bool mIsSelected = false;

    // �J�[�h���
    private CardData mData;

    // �J�[�h�̐ݒ�
    public void Set(CardData data)
    {

        // �J�[�h����ݒ�
        this.mData = data;

        // ID��ݒ肷��
        this.Id = data.Id;

        // �\������摜��ݒ肷��
        // ����͑S�ė��ʕ\���Ƃ���
        //this.CardImage.sprite = Resources.Load<Sprite>("Image/card_back");

        // �I�𔻒�t���O������������
        this.mIsSelected = false;

    }

    /// <summary>
    /// �I�����ꂽ���̏���
    /// </summary>
    public void OnClick()
    {

        // �J�[�h���\�ʂɂȂ��Ă����ꍇ�͖���
        if (this.mIsSelected)
        {
            return;
        }

        Debug.Log("OnClick");

        // �I�𔻒�t���O��L���ɂ���
        this.mIsSelected = true;

        // �J�[�h��\�ʂɂ���
        this.CardImage.sprite = this.mData.ImgSprite;

        // �I������CardId��ۑ����悤�I
        GameStateController.Instance.SelectedCardIdList.Add(this.mData.Id);
    }
}
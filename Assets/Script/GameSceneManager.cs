using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{

    // ��v�����J�[�h���X�gID
    private List<int> mContainCardIdList = new List<int>();

    // �J�[�h�����}�l�[�W���N���X
    public CardCreateManager CardCreate;

    void Start()
    {

        // ��v�����J�[�hID���X�g��������
        this.mContainCardIdList.Clear();

        // �J�[�h���X�g�𐶐�����
        this.CardCreate.CreateCard();
    }

    void Update()
    {

        // �I�������J�[�h���Q���ȏ�ɂȂ�����
        if (GameStateController.Instance.SelectedCardIdList.Count >= 2)
        {

            // �ŏ��ɑI������CardID���擾����
            int selectedId = GameStateController.Instance.SelectedCardIdList[0];

            // 2���ڂɂ������J�[�h�ƈꏏ��������
            if (selectedId == GameStateController.Instance.SelectedCardIdList[1])
            {
                // �J�[�h�̕\���؂�ւ����s��
                this.CardCreate.HideCardList(this.mContainCardIdList);

                Debug.Log($"Contains! {selectedId}");
                // ��v�����J�[�hID��ۑ�����
                this.mContainCardIdList.Add(selectedId);
            }

            // �J�[�h�̕\���؂�ւ����s��
            //this.CardCreate.HideCardList(this.mContainCardIdList);

            // �I�������J�[�h���X�g������������
            GameStateController.Instance.SelectedCardIdList.Clear();

        }
    }
}
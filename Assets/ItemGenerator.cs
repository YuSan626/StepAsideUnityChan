using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefab�@ ��
    public GameObject carPrefab;
    //coinPrefab�@�R�C��
    public GameObject coinPrefab;
    //cornPrefab�@�R�[��
    public GameObject conePrefab;

    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    //�X�^�[�g�n�_
    private int startPos = 80;
    //�S�[���n�_
    private int goalPos = 360;

    //�A�C�e�����o��X�����͈̔́@
    private float posRange = 3.4f;

    private float unitychanB;
    


    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");

  
    }

    // Update is called once per frame
    void Update()
    {




        //���̋������ƂɃA�C�e���𐶐� 
        if (unitychan.transform.position.z- unitychanB > 15)
        { //�ǂ̃A�C�e�����o�����������_���ɐݒ�
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //�R�[����X�������Ɉ꒼���ɐ���
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z+40);
                }
            }
            else
            {
                //���[�����ƂɃA�C�e���𐶐�
                for (int j = -1; j <= 1; j++)
                {
                    //�A�C�e���̎�ނ����߂�
                    int item = Random.Range(1, 11);

                    //�A�C�e����u�������W�̃I�t�Z�b�g�������_���ɐݒ�
                    int offsetZ = Random.Range(-5, 6);


                    //60���R�C����z�u : 30���Ԕz�u �F 10�������Ȃ�
                    if (1 <= item && item <= 6)
                    {
                        //�R�C���𐶐�
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 40 + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //�Ԃ𐶐�
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 40 + offsetZ);
                    }
                }
            }

            this.unitychanB = unitychan.transform.position.z;
        }




          
        {
           
        }



    }
}
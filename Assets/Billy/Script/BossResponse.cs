using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BossResponse : MonoBehaviour
{
    public Boss_Statu statu;
    public Transform BulletPos;
    public GameObject BulletObj;
    public Animator ani;
    private void Awake()
    {
        statu = this.gameObject.GetComponent<Boss_Statu>();
    }
    public void BOSSDead()
    {
        SceneManager.LoadScene(statu.SceneName);
    }

    public void BOSSHurt()
    {
        statu.HP--;
        if (statu.HP <=0)
        {
            ani.SetTrigger("Dead");
        }
    }
    public void LaunchBullet()
    {
        GameObject Obj = Instantiate(BulletObj);
        Obj.transform.position = BulletPos.position;

    }
}

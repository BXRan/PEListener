/*************************************************
	作者: Plane
	邮箱: 1785275942@qq.com
	日期: 2021/03/06 20:16
	功能: 英雄选择界面

    //=================*=================\\
           教学官网：www.qiqiker.com
           关注微信服务号: qiqikertuts
           关注微信公众号: PlaneZhong
               ~~获取更多教学资讯~~
    \\=================*=================//
*************************************************/

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectWindow : WindowRoot {
    public int heroCount;
    public GameObject heroItem;
    public Transform scrollRoot;
    public Button btnSure;

    void Start() {
        for(int i = 0; i < heroCount; i++) {
            GameObject go = Instantiate(heroItem);
            go.transform.SetParent(scrollRoot);
            go.name = "heroItem_" + i;
            go.transform.localScale = Vector3.one;
            OnClickDown(go, ClickItemDown, go, i);
            OnClickUp(go, ClickItemUp, go, i);
            OnDrag(go, DragItem, go, i);
        }

        btnSure.onClick.AddListener(ClickSureBtn);
    }

    private void ClickItemDown(PointerEventData ped, object[] args) {
        GameObject go = args[0] as GameObject;
        int index = (int)args[1];
        Debug.Log("ClickDown:" + go.name + " index:" + index);
    }
    private void ClickItemUp(PointerEventData ped, object[] args) {
        GameObject go = args[0] as GameObject;
        int index = (int)args[1];
        Debug.Log("ClickUp:" + go.name + " index:" + index);
    }
    private void DragItem(PointerEventData ped, object[] args) {
        GameObject go = args[0] as GameObject;
        int index = (int)args[1];
        Debug.Log("Drag:" + go.name + " index:" + index);
    }

    public void ClickSureBtn() {
        Debug.Log("Click Sure Button.");
    }
}

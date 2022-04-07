using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchasebutton : MonoBehaviour
{
    public enum Purchasetype { buycoin1k, buycoin10k, buyhint };
    public Purchasetype purchasetype;

    public void clickpurchasebutton()
    {
        switch (purchasetype)
        {
            case Purchasetype.buycoin1k:
                IAPManager.instance.buycoin1kflow();
                break;
            case Purchasetype.buycoin10k:
                IAPManager.instance.buy10kflow();
                break;
            case Purchasetype.buyhint:
                IAPManager.instance.buyhintflow();
                break;
        }
    }
}

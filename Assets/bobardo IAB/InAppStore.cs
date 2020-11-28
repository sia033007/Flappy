using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Detectors;

/* Apache License. Copyright (C) Bobardo Studio - All Rights Reserved.
 * Unauthorized publishing the plugin with different name is strictly prohibited.
 * This plugin is free and no one has right to sell it to others.
 * http://bobardo.com
 * http://opensource.org/licenses/Apache-2.0
 */

[RequireComponent(typeof(StoreHandler))]
public class InAppStore : MonoBehaviour
{
    public GameObject success, fail, load;
    public Button saveButton;
    public GameObject saveSucceedPanel;
    public Product[] products;

    private int selectedProductIndex;

    void Start()
    {

    }

    public void purchasedSuccessful(Purchase purchase)
    {
        ObscuredPrefs.SetString ("Bonus","Off");
        success.SetActive(true);
        saveButton.gameObject.SetActive(true);
        load.SetActive(false);
        fail.SetActive(false);
        // purchase was successful, give user the pruduct

        switch (selectedProductIndex)
        {
            case 0: DBManager.coin+=60;

                break;
            case 1: DBManager.coin+=80;

                break;
            case 2 : DBManager.coin+=100;

                break;
            case 3 : DBManager.coin+=120;

                break;
            case 4 : DBManager.coin+=150;

                break;
            case 5 : DBManager.coin+=200;

                break;
            default:
                throw new UnassignedReferenceException("you forgot to give user the product after purchase. product: " + purchase.productId);
        }
        
    }

    public void purchasedFailed(int errorCode, string info)
    {
        ObscuredPrefs.SetString ("Bonus","Off");
        success.SetActive(false);
        fail.SetActive(true);
        load.SetActive(false);
        // purchase failed. show user the proper message
        switch (errorCode)
        {
            case 1: // error connecting cafeBazaar
            case 2: // error connecting cafeBazaar
            case 4: // error connecting cafeBazaar
            case 5: // error connecting cafeBazaar

                break;
            case 6: // user canceled the purchase

                break;
            case 7: // purchase failed

                break;
            case 8: // failed to consume product. but the purchase was successful.

                break;
            case 12: // error setup cafebazaar billing
            case 13: // error setup cafebazaar billing
            case 14: // error setup cafebazaar billing

                break;
            case 15: // you should enter your public key

                break;
            case 16: // unkown error happened

                break;
            case 17: // the result from cafeBazaar is not valid.

                break;
        }

    }

    public void userHasThisProduct(Purchase purchase)
    {
        // user already has this product
        switch (selectedProductIndex)
        {
            case 0: // first product

                break;
            case 1: // second product

                break;
            default:
                throw new UnassignedReferenceException("you forgot to give user the product after purchase. product: " + purchase.productId);
        }
    }

    public void failToGetUserInventory(int errorCode, string info)
    {
        // user has not this product or some error happened
        switch (errorCode)
        {
            case 3:  // error connecting cafeBazaar
            case 10: // error connecting cafeBazaar

                break;
            case 9: // user didn't login to cafeBazaar

                break;
            case 11: // user has not this product

                break;
            case 12: // error setup cafebazaar billing
            case 13: // error setup cafebazaar billing
            case 14: // error setup cafebazaar billing

                break;
            case 15: // you should enter your public key

                break;
            case 16: // unkown error happened

                break;
            case 17: // the result from cafeBazaar is not valid.

                break;
        }

    }

    public void purchaseProduct(int productIndex)
    {
        load.SetActive(true);
        selectedProductIndex = productIndex;
        Product product = products[productIndex];
        if (product.type == Product.ProductType.Consumable)
        {
            GetComponent<StoreHandler>().BuyAndConsume(product.productId);
        }
        else if (product.type == Product.ProductType.NonConsumable)
        {
            GetComponent<StoreHandler>().BuyProduct(product.productId);
        }
    }

    public void checkIfUserHasProduct(int productIndex)
    {
        selectedProductIndex = productIndex;
        GetComponent<StoreHandler>().CheckInventory(products[productIndex].productId);
    }
    public void desablesuccess()
    {
        success.SetActive(false);
    }
    public void disablefail()
    {
        fail.SetActive(false);
    }
    IEnumerator dataSave()
    {
        WWWForm form = new WWWForm();
        form.AddField("name",DBManager.username);
        form.AddField("score",DBManager.coin);
        form.AddField("level",DBManager.level);
        form.AddField("planetwo",DBManager.planetwo);
        form.AddField("planethree",DBManager.planethree);
        form.AddField("planefour",DBManager.planefour);
        form.AddField("planefive",DBManager.planefive);
        form.AddField("dragon",DBManager.dragon);

        using(UnityWebRequest request = UnityWebRequest.Post("http://aminunity.orgfree.com/samplegame.php",form))
        {
            yield return request.SendWebRequest();
            if(request.downloadHandler.text == "0")
            {
                Debug.Log("Game saved");
                StartCoroutine(succeedPanel());
            }
            else
            {
                Debug.Log("Save failed" + request.downloadHandler.text);
            }
        }
    }
    public void SaveData()
    {
        StartCoroutine(dataSave());
        StartCoroutine(disableSaveButton());
    }
    IEnumerator disableSaveButton()
    {
        yield return new WaitForSeconds(1f);
        saveButton.gameObject.SetActive(false);
    }
    IEnumerator succeedPanel()
    {
        saveSucceedPanel.SetActive(true);
        yield return new WaitForSeconds(3f);
        saveSucceedPanel.SetActive(false);
    }

}


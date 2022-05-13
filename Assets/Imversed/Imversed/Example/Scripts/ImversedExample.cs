using System.Collections;
using System.Collections.Generic;
using Cosmos.Bank.V1Beta1;
using UnityEngine;
using UnityEngine.UI;
using global::Grpc.Core;

public class ImversedExample : MonoBehaviour
{
    [SerializeField] 
    private Text mText;
    [SerializeField] 
    private Button mButton;
    
    void Start()
    {
        Debug.Log("ButtonAction");
        mText.text = "Press 'Start' button.";
        mButton.onClick.AddListener(OnButtonPress);
    }

    public async void OnButtonPress(){  
      mText.text = "Processed...";  
      Channel channel = new Channel("qs.imversed.com:9090", ChannelCredentials.Insecure);
      var client = new Query.QueryClient(channel);
      var response = client.DenomsMetadata(new QueryDenomsMetadataRequest());

      var result = JsonUtility.FromJson<models.DenomMetadatas>(response.ToString());
      Debug.Log(result.ToString());
      var text = "Result: " + result.metadatas.Count + "\n";
      foreach(models.DenomMetadata meta in result.metadatas) {
          text += meta.name + " (" + meta.description + ") " + meta.symbol + "\n";
          foreach(models.Denom denom in meta.denomUnits) {
            text += " denom: " + denom.denom + " (" + denom.exponent + ")\n";
          }
      }
      mText.text = text;
      channel.ShutdownAsync().Wait();
    }  
}

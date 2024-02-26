using UnityEngine;

public class AddDeviceViewStarter : IWindowStarter
{
    public string GetGroup() => "AddDevice";
    public string GetName() => "AddDeviceView";

    public void SetupModels(ViewController viewController)
    {

    }
}

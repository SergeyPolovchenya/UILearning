namespace App.UI
{
    public class MainViewController : ViewController
    {
        public override void Init(IWindowStarter starter)
        {
            base.Init(starter);
            AppManager.inputFieldView.OnShowWindow += SetWindowInvisibleWrapper;
            AppManager.inputFieldView.OnHideWindow += SetWindowVisibleWrapper;
        }

        private void SetWindowInvisibleWrapper(ViewController controller)
        {
            Depth = 1;
            DisableInteractables();
            canvasGroup.alpha = 0.5f;
        }

        private void SetWindowVisibleWrapper(ViewController controller)
        {
            EnableColliders();
            canvasGroup.alpha = 1f;
        }
    }
}
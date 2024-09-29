using BetterNativeHook;

namespace CustomAlbums.ModExtensions
{ 
    public class AssetEventArgs : EventArgs
    {
        public string AssetName;
        public ReturnValueReference AssetPtr;

        public AssetEventArgs(string assetName, ReturnValueReference assetPtr)
        {
            AssetName = assetName;
            AssetPtr = assetPtr;
        }
    }
}

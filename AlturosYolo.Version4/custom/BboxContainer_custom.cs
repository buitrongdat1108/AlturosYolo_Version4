using System.Runtime.InteropServices;
namespace AlturosYolo.Version4.custom
{
 /// <summary>
 /// C++ Communication object
 /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct BboxContainer_custom
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = YoloWrapper_custom.MaxObjects)]
        internal BboxT_custom[] candidates;
    }
}

using NUnit.Framework;

namespace UGF.Kernel.Editor.Tests
{
    public class TestKernelEditorUtility
    {
        [Test]
        public void GetResourcesFolderPath()
        {
            string path0 = "Assets/Folder0/Folder1/Resources/file.asset";
            string path1 = "Assets/Folder0/Resources/Folder1/Resources/file.asset";
            string path2 = "Assets/Resources/Resources/Resources/file.asset";
            string path3 = "Assets/Folder0/Resources/Folder1/file.asset";
            string expected0 = "file";
            string expected1 = "Folder1/file";

            string actual0 = KernelEditorUtility.GetResourcesFolderPath(path0);
            string actual1 = KernelEditorUtility.GetResourcesFolderPath(path1);
            string actual2 = KernelEditorUtility.GetResourcesFolderPath(path2);
            string actual3 = KernelEditorUtility.GetResourcesFolderPath(path3);

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected0, actual1);
            Assert.AreEqual(expected0, actual2);
            Assert.AreEqual(expected1, actual3);
        }
    }
}

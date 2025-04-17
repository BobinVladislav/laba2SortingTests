using NUnit.Framework.Legacy;
using NUnit.Framework;
using laba2;
using System;
namespace SortingTests
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void SortIfOneItem()
        {
            int[] a = { 1};
            int[] result = Sort.MergeSort(a, 0, a.Length - 1);
            Assert.That(result[0], Is.EqualTo(1));
        }
        [Test]
        public void SortIfSomeItems()
        {
            int[] a = { 1, 5, 4, 2, 8, 1, 9, 3, 6 };
            string result = string.Join(", ", Sort.MergeSort(a, 0, a.Length - 1));
            Assert.That(result, Is.EqualTo("1, 1, 2, 3, 4, 5, 6, 8, 9"));
        }
        [Test]
        public void SortIfNullItems()
        {
            int[] a = {};
            Assert.Throws<IndexOutOfRangeException>(delegate {
                Sort.MergeSort(a, 0, a.Length - 1); });
        }
    }
}

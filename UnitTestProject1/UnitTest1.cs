using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MyLinkedList list = new MyLinkedList();
            list.add(0);
            Assert.AreEqual(1, list.size());

        }

        [TestMethod]
        public void TestContains()
        {
            MyLinkedList list = new MyLinkedList();
            list.add(0);
            Assert.IsTrue(list.contains(0));
        }

        [TestMethod]
        public void TestSize()
        {
            MyLinkedList list = new MyLinkedList();
            list.add(0);
            Assert.AreEqual(1, list.size());
            list.add(1);
            Assert.AreEqual(2, list.size());
        }
        [TestMethod]
        public void TestNotContains()
        {
            MyLinkedList list = new MyLinkedList();
            Assert.IsFalse(list.contains(0));
        }

        [TestMethod]
        public void TestNext()
        {
            MyLinkedList list = new MyLinkedList();
            Assert.IsFalse(list.hasNext());
            Assert.IsNull(list.getNext());
            list.add(1);
            Assert.IsTrue(list.hasNext());
            Assert.IsNotNull(list.getNext());
        }
    }
}

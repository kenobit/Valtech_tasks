using Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AListTestModules
{
    [TestClass]
    public class LList2_tests
    {
        LList2 llist = new LList2(new int[] { 5, 7, 8, 9, 6, 4, 2, 1, 3 });


        [TestMethod]
        [TestCategory("LList2")]
        public void llist2_Size_wrong_counts()
        {
            Assert.AreEqual(9, llist.Size);
        }

        [TestMethod]
        [TestCategory("LList2")]
        public void llist2_Delete_End_returnValue_error()
        {
            Assert.AreEqual(3, llist.DeleteEnd());
        }

        [TestMethod]
        public void llist2_Delete_End_DeleteValue_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.DeleteEnd();
            Assert.AreEqual("1 2 9 5 6 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_AddEnd_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.AddEnd(42);
            Assert.AreEqual("1 2 9 5 6 7 42 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_AddStart_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.AddStart(42);
            Assert.AreEqual("42 1 2 9 5 6 7 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_AddPosition_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.AddPosition(42, 4);
            Assert.AreEqual("1 2 9 5 42 6 7 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_Delete_Position_ReturnValue_error()
        {
            Assert.AreEqual(9, llist.DeletePos(3));
        }

        [TestMethod]
        public void llist2_Delete_Position_DeleteValue_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.DeletePos(3);
            Assert.AreEqual("1 2 9 6 7 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_Delete_Start_ReturnValue_error()
        {
            Assert.AreEqual(5, llist.DeleteStart());
        }

        [TestMethod]
        public void llist2_Delete_Start_DeleteValue_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.DeleteStart();
            Assert.AreEqual("2 9 5 6 7 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_Get_error()
        {
            Assert.AreEqual(6, llist.Get(4));
        }

        [TestMethod]
        public void llist2_Init_error()
        {
            LList2 ll = new LList2();
            ll.Init(new int[] { 1, 2, 9, 5, 6, 2 });
            LList1 al1 = new LList1();
            al1.Init(new int[] { 1, 2, 9, 5, 6, 2 });
           // llist al1 = new llist(new int[] { 1, 2, 9, 5, 6, 2 });
            Assert.AreEqual(ll.ToString(), al1.ToString());
            //Assert.AreEqual("1 2 9 5 6 ", al.ToString());
        }

        [TestMethod]
        public void llist2_Max_Value_error()
        {
            Assert.AreEqual(9, llist.Max());
        }

        [TestMethod]
        public void llist2_Max_Index_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            Assert.AreEqual(2, ll.MaxIndex());
        }

        [TestMethod]
        public void llist2_Min_Value_error()
        {
            Assert.AreEqual(1, llist.Min());
        }

        [TestMethod]
        public void llist2_Min_Index_error()
        {
            LList2 ll = new LList2(new int[] { 0, 2, 9, 5, 6, 7 });
            Assert.AreEqual(0, ll.MinIndex());
        }

        [TestMethod]
        public void llist2_ToString_error()
        {
            Assert.AreEqual("5 7 8 9 6 4 2 1 3 ", llist.ToString());
        }

        [TestMethod]
        public void llist2_Reverse_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.Reverse();
            Assert.AreEqual("7 6 5 9 2 1 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_Set_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.Set(42, 3);
            Assert.AreEqual("1 2 9 42 6 7 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_Sort_error()
        {
            LList2 ll = new LList2(new int[] { 2, 1, 9, 5, 6, 7 });
            ll.Sort();
            Assert.AreEqual("1 2 5 6 7 9 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_Half_Reverse_even_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7, 3 });
            ll.HalfReverse();
            Assert.AreEqual("9 2 1 5 6 7 3 ", ll.ToString());
        }

        [TestMethod]
        public void llist2_Half_Reverse_odd_error()
        {
            LList2 ll = new LList2(new int[] { 1, 2, 9, 5, 6, 7 });
            ll.HalfReverse();
            Assert.AreEqual("9 2 1 5 6 7 ", ll.ToString());
        }
    }
}

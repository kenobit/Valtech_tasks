using Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AListTestModules
{
    [TestClass]

    public class AList2_tests
    {
        AList2 aList2 = new AList2(new int[] { 5, 7, 8, 9, 6, 4, 2, 1, 3 });


        [TestMethod]
        public void AList2_Size_wrong_counts()
        {
            Assert.AreEqual(9, aList2.Size);
        }

        [TestMethod]
        public void AList2_Delete_End_returnValue_error()
        {
            Assert.AreEqual(3, aList2.DeleteEnd());
        }

        [TestMethod]
        public void AList2_Delete_End_DeleteValue_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeleteEnd();
            Assert.AreEqual("1 2 9 5 6 ", al.ToString());
        }

        [TestMethod]
        public void AList2_AddEnd_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddEnd(42);
            Assert.AreEqual("1 2 9 5 6 7 42 ", al.ToString());
        }

        [TestMethod]
        public void AList2_AddStart_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddStart(42);
            Assert.AreEqual("42 1 2 9 5 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList2_AddPosition_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddPosition(42, 4);
            Assert.AreEqual("1 2 9 5 42 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList2_Delete_Position_ReturnValue_error()
        {
            Assert.AreEqual(9, aList2.DeletePos(3));
        }

        [TestMethod]
        public void AList2_Delete_Position_DeleteValue_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeletePos(3);
            Assert.AreEqual("1 2 9 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList2_Delete_Start_ReturnValue_error()
        {
            Assert.AreEqual(5, aList2.DeleteStart());
        }

        [TestMethod]
        public void AList2_Delete_Start_DeleteValue_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeleteStart();
            Assert.AreEqual("2 9 5 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList2_Get_error()
        {
            Assert.AreEqual(6, aList2.Get(4));
        }

        [TestMethod]
        public void AList2_Init_error()
        {
            AList2 al = new AList2();
            al.Init(new int[] { 1, 2, 9, 5, 6, 2 });
            AList2 al1 = new AList2();
            al1.Init(new int[] { 1, 2, 9, 5, 6, 2 });
           // AList2 al1 = new AList2(new int[] { 1, 2, 9, 5, 6, 2 });
            Assert.AreEqual(al.ToString(), al1.ToString());
            //Assert.AreEqual("1 2 9 5 6 ", al.ToString());
        }

        [TestMethod]
        public void AList2_Max_Value_error()
        {
            Assert.AreEqual(9, aList2.Max());
        }

        [TestMethod]
        public void AList2_Max_Index_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            Assert.AreEqual(2, al.MaxIndex());
        }

        [TestMethod]
        public void AList2_Min_Value_error()
        {
            Assert.AreEqual(1, aList2.Min());
        }

        [TestMethod]
        public void AList2_Min_Index_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            Assert.AreEqual(0, al.MinIndex());
        }

        [TestMethod]
        public void AList2_ToString_error()
        {
            Assert.AreEqual("5 7 8 9 6 4 2 1 3 ", aList2.ToString());
        }

        [TestMethod]
        public void AList2_Reverse_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.Reverse();
            Assert.AreEqual("7 6 5 9 2 1 ", al.ToString());
        }

        [TestMethod]
        public void AList2_Set_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.Set(42, 3);
            Assert.AreEqual("1 2 9 42 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList2_Sort_error()
        {
            AList2 al = new AList2(new int[] { 2, 1, 9, 5, 6, 7 });
            al.Sort();
            Assert.AreEqual("1 2 5 6 7 9 ", al.ToString());
        }

        [TestMethod]
        public void AList2_Half_Reverse_even_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7, 3 });
            al.HalfReverse();
            Assert.AreEqual("9 2 1 5 6 7 3 ", al.ToString());
        }

        [TestMethod]
        public void AList2_Half_Reverse_odd_error()
        {
            AList2 al = new AList2(new int[] { 1, 2, 9, 5, 6, 7 });
            al.HalfReverse();
            Assert.AreEqual("9 2 1 5 6 7 ", al.ToString());
        }
    }
}

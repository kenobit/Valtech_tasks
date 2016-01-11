using Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AListTestModules
{
    [TestClass]
    public class AList1_tests
    {
        AList1 aList1 = new AList1(new int[] { 5, 7, 8, 9, 6, 4, 2, 1, 3 });


        [TestMethod]
        public void AList1_Size_wrong_counts()
        {
            Assert.AreEqual(9, aList1.Size);
        }

        [TestMethod]
        public void AList1_Delete_End_returnValue_error()
        {
            Assert.AreEqual(3, aList1.DeleteEnd());
        }

        [TestMethod]
        public void AList1_Delete_End_DeleteValue_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeleteEnd();
            Assert.AreEqual("1 2 9 5 6 ", al.ToString());
        }

        [TestMethod]
        public void AList1_AddEnd_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddEnd(42);
            Assert.AreEqual("1 2 9 5 6 7 42 ", al.ToString());
        }

        [TestMethod]
        public void AList1_AddStart_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddStart(42);
            Assert.AreEqual("42 1 2 9 5 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList1_AddPosition_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddPosition(42, 4);
            Assert.AreEqual("1 2 9 5 42 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList1_Delete_Position_ReturnValue_error()
        {
            Assert.AreEqual(9, aList1.DeletePos(3));
        }

        [TestMethod]
        public void AList1_Delete_Position_DeleteValue_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeletePos(3);
            Assert.AreEqual("1 2 9 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList1_Delete_Start_ReturnValue_error()
        {
            Assert.AreEqual(5, aList1.DeleteStart());
        }

        [TestMethod]
        public void AList1_Delete_Start_DeleteValue_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeleteStart();
            Assert.AreEqual("2 9 5 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList1_Get_error()
        {
            Assert.AreEqual(6, aList1.Get(4));
        }

        [TestMethod]
        public void AList1_Init_error()
        {
            AList1 al = new AList1();
            al.Init(new int[] { 1, 2, 9, 5, 6, 7 });
            Assert.AreEqual("1 2 9 5 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList1_Max_Value_error()
        {
            Assert.AreEqual(9, aList1.Max());
        }

        [TestMethod]
        public void AList1_Max_Index_error()
        {
            Assert.AreEqual(3, aList1.MaxIndex());
        }

        [TestMethod]
        public void AList1_Min_Value_error()
        {
            Assert.AreEqual(1, aList1.Min());
        }

        [TestMethod]
        public void AList1_Min_Index_error()
        {
            Assert.AreEqual(7, aList1.MinIndex());
        }

        [TestMethod]
        public void AList1_ToString_error()
        {
            Assert.AreEqual("5 7 8 9 6 4 2 1 3 ", aList1.ToString());
        }

        [TestMethod]
        public void AList1_Reverse_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.Reverse();
            Assert.AreEqual("7 6 5 9 2 1 ", al.ToString());
        }

        [TestMethod]
        public void AList1_Set_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.Set(42, 3);
            Assert.AreEqual("1 2 9 42 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList1_Sort_error()
        {
            AList1 al = new AList1(new int[] { 2, 1, 9, 5, 6, 7 });
            al.Sort();
            Assert.AreEqual("1 2 5 6 7 9 ", al.ToString());
        }

        [TestMethod]
        public void AList1_Half_Reverse_even_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7, 3 });
            al.HalfReverse();
            Assert.AreEqual("9 2 1 5 6 7 3 ", al.ToString());
        }

        [TestMethod]
        public void AList1_Half_Reverse_odd_error()
        {
            AList1 al = new AList1(new int[] { 1, 2, 9, 5, 6, 7 });
            al.HalfReverse();
            Assert.AreEqual("9 2 1 5 6 7 ", al.ToString());
        }
    }
}

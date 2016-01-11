using Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AListTestModules
{
    [TestClass]
    public class AList0_tests
    {
        AList0 aList0 = new AList0(new int[] { 5, 7, 8, 9, 6, 4, 2, 1, 3 });


        [TestMethod]
        public void AList0_Size_wrong_counts()
        {
            Assert.AreEqual(9, aList0.Size);
        }

        [TestMethod]
        public void AList0_Delete_End_returnValue_error()
        {
            Assert.AreEqual(3, aList0.DeleteEnd());
        }

        [TestMethod]
        public void AList0_Delete_End_DeleteValue_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeleteEnd();
            Assert.AreEqual("1 2 9 5 6 ", al.ToString());
        }

        [TestMethod]
        public void AList0_AddEnd_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddEnd(42);
            Assert.AreEqual("1 2 9 5 6 7 42 ", al.ToString());
        }

        [TestMethod]
        public void AList0_AddStart_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddStart(42);
            Assert.AreEqual("42 1 2 9 5 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList0_AddPosition_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.AddPosition(42, 4);
            Assert.AreEqual("1 2 9 5 42 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList0_Delete_Position_ReturnValue_error()
        {
            Assert.AreEqual(9, aList0.DeletePos(3));
        }

        [TestMethod]
        public void AList0_Delete_Position_DeleteValue_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeletePos(3);
            Assert.AreEqual("1 2 9 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList0_Delete_Start_ReturnValue_error()
        {
            Assert.AreEqual(5, aList0.DeleteStart());
        }

        [TestMethod]
        public void AList0_Delete_Start_DeleteValue_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.DeleteStart();
            Assert.AreEqual("2 9 5 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList0_Get_error()
        {
            Assert.AreEqual(6, aList0.Get(4));
        }

        [TestMethod]
        public void AList0_Init_error()
        {
            AList0 al = new AList0();
            al.Init(new int[] { 1, 2, 9, 5, 6, 7 });
            Assert.AreEqual("1 2 9 5 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList0_Max_Value_error()
        {
            Assert.AreEqual(9, aList0.Max());
        }

        [TestMethod]
        public void AList0_Max_Index_error()
        {
            Assert.AreEqual(3, aList0.MaxIndex());
        }

        [TestMethod]
        public void AList0_Min_Value_error()
        {
            Assert.AreEqual(1, aList0.Min());
        }

        [TestMethod]
        public void AList0_Mix_Index_error()
        {
            Assert.AreEqual(7, aList0.MinIndex());
        }

        [TestMethod]
        public void AList0_ToString_error()
        {
            Assert.AreEqual("5 7 8 9 6 4 2 1 3 ", aList0.ToString());
        }

        [TestMethod]
        public void AList0_Reverse_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.Reverse();
            Assert.AreEqual("7 6 5 9 2 1 ", al.ToString());
        }

        [TestMethod]
        public void AList0_Set_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.Set(42, 3);
            Assert.AreEqual("1 2 9 42 6 7 ", al.ToString());
        }

        [TestMethod]
        public void AList0_Sort_error()
        {
            AList0 al = new AList0(new int[] { 2, 1, 9, 5, 6, 7 });
            al.Sort();
            Assert.AreEqual("1 2 5 6 7 9 ", al.ToString());
        }

        [TestMethod]
        public void AList0_Half_Reverse_even_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7, 3 });
            al.HalfReverse();
            Assert.AreEqual("9 2 1 5 6 7 3 ", al.ToString());
        }

        [TestMethod]
        public void AList0_Half_Reverse_odd_error()
        {
            AList0 al = new AList0(new int[] { 1, 2, 9, 5, 6, 7 });
            al.HalfReverse();
            Assert.AreEqual("9 2 1 5 6 7 ", al.ToString());
        }
    }
}

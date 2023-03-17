namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 5, 20, 6 })]
        [TestCase(new[] { int.MinValue, int.MaxValue })]
        [TestCase(new int[0])]

        public void Constructor_Shuld_Create_Data_With_ValidInput(int[] parameters)
        {
            Database database = new Database(parameters);

            Assert.AreEqual(parameters.Length, database.Count);
        }

        [TestCase(new[] { 2, 3 },
                    new[] { 6, 15 },
                      4)]
        public void Add_With_Valid_Data_Should_Pass(int[] ctorParameters, int[] paramsToAdd, int expectedCount)
        {
            Database database = new Database(ctorParameters);

            foreach (var parameter in paramsToAdd)
            {
                database.Add(parameter);
            }

            Assert.AreEqual(expectedCount, database.Count);
        }

        [TestCase(new[] { 15, 16 },
                    new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 })]
        public void Add_With_Invalid_Data_Should_ThorException(int[] ctorParameters, int[] paramsToAdd)
        {
            Database database = new Database(ctorParameters);

            foreach (var parameter in paramsToAdd)
            {
                database.Add(parameter);
            }

            Assert.Throws<InvalidOperationException>(() =>
            database.Add(17));
        }


        [TestCase(new[] { 2, 3 },
                   new[] { 6, 15 },
                   new[] { 5, 12 },
                     2)]
        public void Remove_With_Valid_Data_Should_Pass(int[] ctorParameters, int[] paramsToAdd, int[] paramsToRemove, int expectedCount)
        {
            Database database = new Database(ctorParameters);

            foreach (var parameter in paramsToAdd)
            {
                database.Add(parameter);
            }

            for (int i = 0; i < paramsToRemove.Length; i++)
            {
                database.Remove();
            }

            Assert.AreEqual(expectedCount, database.Count);
        }

        [TestCase(new[] { 2, 3 },
                  new[] { 5, 12 }
                    )]
        public void Remove_With_Invalid_Data_Should_ThrowException(int[] ctorParameters, int[] paramsToRemove)
        {
            Database database = new Database(ctorParameters);

            for (int i = 0; i < paramsToRemove.Length; i++)
            {
                database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() =>
            database.Remove());
        }

        [TestCase(new[] { 15, 16, 17, 999 })]

        public void Fetch_Should_Pass(int[] ctorParameters)
        {
            Database database = new Database(ctorParameters);

            int[] copyParameters = database.Fetch();

            CollectionAssert.AreEqual(copyParameters, ctorParameters);
        }
    }
}

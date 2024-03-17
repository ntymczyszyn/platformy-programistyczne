using lab1;
namespace Tests1
{
    [TestClass]
    public class UnitTest1
    {   // test przykladowy
        [TestMethod]
        public void TestMethodCountElements()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            const int seed = 10;
            foreach (int i in sizes)
            {
                Problem problem = new Problem(i, seed);
                Assert.AreEqual(i, problem.items.Count);
            }
        }
        // co najmniej jeden przedmiot spelnia ograniczenia, to zwrocono co najmniej jeden element.
        [TestMethod]
        public void TestMethodWhenOneItemCouldBePacked()
        {
            Problem problem = new Problem();
            problem.items.Add(new Item(0, 10, 5));
            problem.items.Add(new Item(0, 12, 1));
            Result result = problem.Solve(5);

            Assert.AreEqual(1, result.packed_items.Count);
        }

        // czy jesli zaden przedmiot nie spelnia ograniczen, to zwrocono puste rozwiazanie.
        [TestMethod]
        public void TestMethodWhenNoItemCouldBePacked()
        {
            Problem problem = new Problem();
            problem.items.Add(new Item(0, 10, 20));
            Result result = problem.Solve(5);

            Assert.AreEqual(0, result.packed_items.Count);
        }

        // czy kolejnosc przedmiotow ma wplyw na znalezione rozwiazanie
        [TestMethod]
        public void TestMethodDoesOrderOfObjectsMatter()
        {
            Problem problem1 = new Problem();
            problem1.items.Add(new Item(0, 10, 20));
            problem1.items.Add(new Item(2, 23, 10));
            problem1.items.Add(new Item(1, 4, 1));
            Result result1 = problem1.Solve(12);

            Problem problem2 = new Problem();
            problem2.items.Add(new Item(0, 4, 1));
            problem2.items.Add(new Item(1, 10, 20));
            problem2.items.Add(new Item(2, 23, 10));
            Result result2 = problem1.Solve(12);

            Assert.AreEqual(result1.total_weight, result2.total_weight);

            var sorted_packed_items1 = result1.packed_items.OrderBy(s => s.id).ToList();
            var sorted_packed_items2 = result2.packed_items.OrderBy(s => s.id).ToList();
            CollectionAssert.AreEqual(sorted_packed_items1, sorted_packed_items2);
        }
        // poprawnosci wyniku dla konkretnej instancji
        [TestMethod]
        public void TestMethodSolveMethodGivesCorrectResults()
        {
            Problem problem = new Problem(10, 1);
            Result result = problem.Solve(10);
            
            List<Item> expected_packed_items = new List<Item>();
            expected_packed_items.Add(new Item(0, 3, 1));
            expected_packed_items.Add(new Item(2, 6, 4));
            expected_packed_items.Add(new Item(5, 1, 3));

            Assert.AreEqual(3, result.packed_items.Count);
            CollectionAssert.AreEqual(expected_packed_items, result.packed_items);
            Assert.AreEqual(8, result.total_weight);
            Assert.AreEqual(10, result.total_value);
        }

        [TestMethod]
        public void TestMethodDifferentSeedsCreateDifferentItems()
        {
            Problem problem1 = new Problem(10, 1);
            Problem problem2 = new Problem(10, 10);

            CollectionAssert.AreNotEqual(problem1.items, problem2.items);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid capacity.")]
        public void TestMethodWhenCapacityIsLessThanOne_ThrowsArgumentException()
        {
            Problem problem = new Problem(10,1);
            Result result = problem.Solve(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid number of items.")]
        public void TestMethodWhenNumberOfItemsIsLessThanOne_ThrowsArgumentException()
        {
            Problem problem = new Problem(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid seed.")]
        public void TestMethodWhenSeedIsLessThanOne_ThrowsArgumentException()
        {
            Problem problem = new Problem(12, 0);
        }

    }
}
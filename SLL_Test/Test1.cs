using SLL;

namespace SLL_Test
{
	[TestClass]
	public sealed class Test1
	{
		public LinkedList CreateTestList()
		{
			var list = new LinkedList();
			list.AddLast("Joe Blow");
			list.AddLast("Joe Schmoe");
			list.AddLast("John Smith");
			list.AddLast("Jane Doe");
			list.AddLast("Bob Bobberson");
			list.AddLast("Sam Sammerson");
			list.AddLast("Dave Daverson");
			return list;
		}

		[TestMethod]
		public void TestAddFirst()
		{
			LinkedList list = new LinkedList();
			list.AddFirst("William Garrison");
			Assert.AreEqual(1, list.Count);
			Assert.AreEqual("William Garrison", list.Head.Value);
			Assert.AreEqual("Joe Blow", list.Head.Next.Value);
		}
	}
}

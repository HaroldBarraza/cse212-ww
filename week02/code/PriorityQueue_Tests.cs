using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Basic enqueue and dequeue operations with different priorities
    // Expected Result: Elements should be dequeued in correct priority order (highest first)
    // Defect(s) Found:
    // - Not returning 'high' first as it should
    // - Items coming out in wrong order
    // - Priority system not working right
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low",1);
        priorityQueue.Enqueue("medium", 2);
        priorityQueue.Enqueue("high", 3);

        Assert.AreEqual("high", priorityQueue.Dequeue());
        Assert.AreEqual("medium", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Multiple elements with same priority
    // Expected Result: Elements with same priority should maintain FIFO order
    // Defect(s) Found:
    // - Not returning items in first-in-first-out order
    // - Order gets mixed up for same-priority items
    // - Queue not remembering addition order correctly
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 2);
        priorityQueue.Enqueue("item2", 2);
        priorityQueue.Enqueue("item3", 2);

        Assert.AreEqual("item1", priorityQueue.Dequeue());
        Assert.AreEqual("item2", priorityQueue.Dequeue());
        Assert.AreEqual("item3", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}
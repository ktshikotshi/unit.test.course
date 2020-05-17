using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    
    [TestFixture]
    public class StackTests
    {

        [Test]
        public void Push_PushEmptyObject_ThrowsArgumentNullException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_PushSingleObject_StackMustContainSingleObject(){
            var stack = new Stack<string>();

            stack.Push("Hello world!");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Push_Push2Objects_StackMustContain2Objects(){
            var stack = new Stack<string>();

            stack.Push("Hello world!");
            stack.Push("Bye world!");

            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Pop_PopEmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WhenCalled_ReturnFirstItemOnStack()
        {
            var stack = new Stack<string>();
            stack.Push("Hello World!");
            stack.Push("Bye World!");
            var result = stack.Pop();

            Assert.That(result, Is.EqualTo("Bye World!").IgnoreCase);
        }

        [Test]
        public void Pop_WhenCalled_RemoveFirstObjectFromStack()
        {
            var stack = new Stack<string>();
            stack.Push("Hello World!");
            stack.Push("Bye World!");
            var count = stack.Count;

            stack.Pop();

            Assert.AreEqual(stack.Count, count - 1);
        }

        [Test]
        public void Peek_PeakEmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        public void Peek_PeakStack_ReturnsFirstObject()
        {
            var stack = new Stack<string>();
            stack.Push("Hello World!");
            stack.Push("Bye World!");
            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("Bye World!").IgnoreCase);
        }

        [Test]
        public void Peek_WhenCalled_StackSizeMustNotChange()
        {
            var stack = new Stack<string>();
            stack.Push("Hello World!");
            stack.Push("Bye World!");
            var count = stack.Count;

            stack.Peek();

            Assert.AreEqual(stack.Count, count);
        }
    }
}
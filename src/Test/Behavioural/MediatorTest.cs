namespace Design.Test.Behavioural
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Design.Patterns.Behavioural.Mediator;

    using NUnit.Framework;

    [TestFixture]
    public class MediatorTest
    {
        #region Methods

        [Test]
        public void CanUseMediator()
        {
            var helloWorld = "Hello world";
            var user1 = new User("1");
            var user2 = new User("2");
            var user3 = new User("3");
            var chatRoom = new ChatRoom();

            chatRoom.Register(user1);
            chatRoom.Register(user2);
            chatRoom.Register(user3);

            Assert.AreEqual(string.Empty, user1.Message);
            Assert.AreEqual(string.Empty, user2.Message);
            Assert.AreEqual(string.Empty, user3.Message);

            chatRoom.NotifyAll(helloWorld);

            Assert.AreEqual(helloWorld, user1.Message);
            Assert.AreEqual(helloWorld, user2.Message);
            Assert.AreEqual(helloWorld, user3.Message);
        }

        #endregion Methods
    }
}
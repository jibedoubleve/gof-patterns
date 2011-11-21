namespace Design.Test.Behavioural
{
    using Design.Patterns.Behavioural.Memento;

    using NUnit.Framework;

    [TestFixture]
    public class MementoTest
    {
        #region Methods

        [Test]
        public void CanSaveState()
        {
            var originator = new Originator(15);
            var memento = originator.SaveState();

            Assert.AreEqual(15, memento.State);

            originator = new Originator(256);
            originator.SetState(memento);

            Assert.AreEqual(15, originator.State);
        }

        [Test]
        public void CanUserCaretaker()
        {
            var c = new Caretaker();
            var o = new Originator(0);

            //I stack the different states of the object
            for (int i = 0; i < 10; i++)
            {
                o.State = i;
                c.PushState(o);
            }

            //I unstack the different state of the object
            for (int i = 10; i < 0; i--)
            {
                c.PopState(o);
                Assert.AreEqual(i, o.State);
            }
        }

        #endregion Methods
    }
}
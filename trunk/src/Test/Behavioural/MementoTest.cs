using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Design.Patterns.Behavioural.Memento;

namespace Design.Test.Behavioural
{
    [TestFixture]
    public class MementoTest
    {
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
    }
}

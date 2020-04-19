using Microsoft.VisualStudio.TestTools.UnitTesting;
using FantasyLibrary;
namespace FantasyTests
{
    [TestClass]
    public class Fantasy
    {
        [TestMethod]
        public void CanSetRegisterA()
        {
            VM vm = new VM();
            vm.Registers[VM.AReg]= 5;
            Assert.AreEqual(vm.Registers[VM.AReg], 5);
        }

        [TestMethod]
        public void CanSetRegisterB()
        {
            VM vm = new VM();
            vm.Registers[VM.BReg] = 5;
            Assert.AreEqual(vm.Registers[VM.BReg], 5);
        }

        [TestMethod]
        public void CanAddToA()
        {
            VM vm = new VM();
            vm.Registers[VM.AReg] = 3;
            vm.Registers[VM.BReg] = 3;
            vm.Add(VM.AReg, VM.BReg);
            Assert.AreEqual(vm.Registers[VM.AReg], 6);

            vm.Add(VM.AReg, VM.AReg);
            Assert.AreEqual(vm.Registers[VM.AReg], 12);

        }

        [TestMethod]
        public void Overflows()
        {
            VM vm = new VM();
            vm.Registers[VM.AReg] = 255;
            vm.Registers[VM.BReg] = 1;
            vm.Add(VM.AReg, VM.BReg);
            Assert.AreEqual(vm.Registers[VM.AReg], 0);
            Assert.IsTrue(vm.HasOverflow);
        }
    }
}

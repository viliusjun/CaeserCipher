using NUnit.Framework;

namespace Tests.tests
{
    public class CaeserCipherTest
    {
        [Test]
        public void CiperMessageTest()
        {
            Assert.AreEqual("Yjxynsl ymj Hfjxjw Hnumjw!",
                new CaeserCipher.CaeserCipher().CipherMessage("Testing the Caeser Cipher!", 5));
            
            Assert.AreEqual("Testing the Caeser Cipher!",
                new CaeserCipher.CaeserCipher().CipherMessage("Yjxynsl ymj Hfjxjw Hnumjw!", 26-5));
            
            Assert.AreEqual("Testing the Caeser Cipher!",
                new CaeserCipher.CaeserCipher().CipherMessage("Testing the Caeser Cipher!", 0));
        }
        
        [Test]
        public void CiperLetterTest()
        {
            Assert.AreEqual('t', new CaeserCipher.CaeserCipher().CipherLetter('a', 19));
            Assert.AreEqual('a', new CaeserCipher.CaeserCipher().CipherLetter('t', 26-19));
            Assert.AreEqual('@', new CaeserCipher.CaeserCipher().CipherLetter('@', 3));
            Assert.AreEqual('3', new CaeserCipher.CaeserCipher().CipherLetter('3', 6));
            
            Assert.AreNotEqual('a', new CaeserCipher.CaeserCipher().CipherLetter('3', 100));
        }
    }
}
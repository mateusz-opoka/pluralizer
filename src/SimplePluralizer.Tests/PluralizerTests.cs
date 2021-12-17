using NUnit.Framework;

namespace SimplePluralizer.Tests
{
    [TestFixture]
    public class PluralizerTests
    {
        [TestCase(0, ExpectedResult = "dni")]
        [TestCase(1, ExpectedResult = "dzień")]
        [TestCase(2, ExpectedResult = "dni")]
        [TestCase(4, ExpectedResult = "dni")]
        [TestCase(5, ExpectedResult = "dni")]
        [TestCase(22, ExpectedResult = "dni")]
        [TestCase(100, ExpectedResult = "dni")]
        [TestCase(212, ExpectedResult = "dni")]
        public string Format_OnPolishNoun_WithoutGenetiveForm_ShouldReturnCorrectForm(int n) =>
            new Pluralizer("dzień", "dni").Format(n);

        [TestCase(0, ExpectedResult = "testów")]
        [TestCase(1, ExpectedResult = "test")]
        [TestCase(2, ExpectedResult = "testy")]
        [TestCase(4, ExpectedResult = "testy")]
        [TestCase(5, ExpectedResult = "testów")]
        [TestCase(10, ExpectedResult = "testów")]
        [TestCase(100, ExpectedResult = "testów")]
        [TestCase(101, ExpectedResult = "testów")]
        [TestCase(102, ExpectedResult = "testy")]
        [TestCase(212, ExpectedResult = "testów")]
        [TestCase(315, ExpectedResult = "testów")]
        public string Format_OnPolishNoun_WithGenetiveForm_ShouldReturnCorrectForm(int n) =>
            new Pluralizer("test", "testy", "testów").Format(n);
    }
}

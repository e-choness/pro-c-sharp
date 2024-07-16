using ProSharp.Enums;

namespace ProCSharpTests.Enums
{
    [TestFixture]
    public class EnumTypesTests
    {
        [Test]
        public void GetEnumType_ShouldPrintEnumValues()
        {
            // Arrange
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            EnumTypes.GetEnumType();

            // Assert
            var expected = string.Join(", ", Enum.GetValuesAsUnderlyingType<Nums>());
            Assert.That(sw.ToString().Trim(), Is.EqualTo(expected));
        }

        [TestCase(EmployType.Manager, "How about stock options instead?")]
        [TestCase(EmployType.Grunt, "You have got to be kidding...")]
        [TestCase(EmployType.Contractor, "You already get enough cash...")]
        [TestCase(EmployType.VicePresident, "Very good, sir")]
        public void AskForBonus_ShouldReturnCorrectMessage(EmployType type, string expected)
        {
            // Act
            var result = typeof(EnumTypes)
                         .GetMethod("AskForBonus", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                         ?.Invoke(null, [type]);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ShowBonus_ShouldPrintCorrectMessage()
        {
            // Arrange
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            EnumTypes.ShowBonus();

            // Assert
            var expected = "=> Show bonus to grunts\nYou have got to be kidding...";
            Assert.That(sw.ToString().Trim().Replace("\r", ""), Is.EqualTo(expected));
        }

        [Test]
        public void AskForContract_ShouldPrintCorrectMessage()
        {
            // Arrange
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            EnumTypes.AskForContract();

            // Assert
            var output = sw.ToString().Trim().Replace("\r", "").Split('\n');
            Assert.Multiple(() =>
            {
                Assert.That(output[0].Trim(), Is.EqualTo("None? True"));
                Assert.That(output[1].Trim(), Is.EqualTo("Email? True"));
                Assert.That(output[2].Trim(), Is.EqualTo("Phone? True"));
                Assert.That(output[3].Trim(), Is.EqualTo("Text? True"));
            });
        }
    }
}

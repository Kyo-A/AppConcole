using AppConsole.Tests;
using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace AppConsole_Test
{
    [TestClass]
    public class CalculTests
    {
        Calcul calcul;

        // moq cree de fausses implementations a partir d'une abstraction(interface
        // ou classe abstraite)
        ICalculService calculService = Mock.Of<ICalculService>();

        // la methode decoree sera executee avant chaque test.
        [TestInitialize()]
        public void Initialize()
        {
            calcul = new Calcul(calculService);
        }

        // la methode decoree sera executee seulement apres chaque test.
        [TestCleanup()]
        public void ClassCleanup()
        {
            calcul = null;
        }

        [TestMethod]
        public void G_TestSommeAddTwo_2_3_9()
        {
            // Creation des objets factices de la methode AddTwo() 
            Mock.Get(calculService).Setup(m => m.AddTwo(2)).Returns(4);
            Mock.Get(calculService).Setup(m => m.AddTwo(3)).Returns(5);

            calcul.SommeAddTwo(2, 3).Should().Be(9, "2 + 2 + 3 + 2 = 9");

            Mock.Get(calculService).Verify(m => m.AddTwo(2), Times.Once());
            Mock.Get(calculService).Verify(m => m.AddTwo(3), Times.Once());

        }

        [TestMethod]
        public void G_TestSommeCarre_2_3_13()
        {
            // Creation des objets factices de la methode Carre() 
            Mock.Get(calculService).Setup(m => m.Carre(2)).Returns(4);
            Mock.Get(calculService).Setup(m => m.Carre(3)).Returns(9);

            calcul.SommeCarre(2, 3).Should().Be(13, "2*2 + 3*3 = 13");

            Mock.Get(calculService).Setup(m => m.Carre(4)).Returns(16);
            Mock.Get(calculService).Setup(m => m.Carre(3)).Returns(9);

            calcul.SommeCarre(4, 3).Should().Be(25, "4*4 + 3*3 = 25");

            //Pour verifier que le mock a bien ete appele
            //Pour verifier que carre(2) a ete appelee une seule fois
            Mock.Get(calculService).Verify(m => m.Carre(2), Times.Once());
            Mock.Get(calculService).Verify(m => m.Carre(3), Times.Exactly(2));
            Mock.Get(calculService).Verify(m => m.Carre(4), Times.Once());

            // Le test echouera car nous n avons jamais appele Carre(4) dans SETUP ... RETURNS 
            // Mock.Get(calculService).Verify(m => m.Carre(4));
        }

        [DataTestMethod]
        [DataRow(2, 3, 13)]
        [DataRow(2, 2, 8)]
        public void H_TestSommeCarre_NombresPositifs_NombrePositif(int a, int b, int c)
        {
            // When pour retourner une valeur si une condition est respectee
            Mock.Get(calculService).When(() => a > 0)
                .Setup(m => m.Carre(a))
                .Returns(a * a);
            Mock.Get(calculService).When(() => b > 0)
                .Setup(m => m.Carre(b))
                .Returns(b * b);
            calcul.SommeCarre(a, b).Should().Be(c, "2*2 + 3*3 = 13");
        }

        [TestMethod]
        [TestCategory("On verifie que la somme de 2 et 2 est bien 4")]
        public void A_TestSomme_2_2_4()
        {
            //if (calcul.Somme(2, 2) != 4)
            //{
            //    // Fail permet de faire echouer le test
            //    Assert.Fail("Probleme d'addition");
            //}
            Assert.AreEqual(4, calcul.Somme(2, 2), "Resultat attendu = 4");
            Assert.AreNotEqual(5, calcul.Somme(2, 2));
            // Fluent Assertions
            calcul.Somme(2, 2).Should().Be(4, "2 + 2 = 4");
        }

        // Verifie si une methode leve une exception
        [TestMethod]
        // [ExpectedException(typeof(DivideByZeroException))]
        public void C_TestDivision_2_0_Exception()
        {
            Action act = () => calcul.Division(2, 0);
            act.Should().Throw<DivideByZeroException>();
        }

        [Ignore]
        [TestMethod]
        public void B_TestSomme_NombresPositifs()
        {
            using (new AssertionScope())
            {
                5.Should().Be(calcul.Somme(2, 4));
                10.Should().Be(calcul.Somme(5, 4));
            }
        }

        [TestMethod]
        public void D_TestSomme_3_3_NombrePair()
        {
            calcul.Somme(2, 2).Should().Match(x => x % 2 == 0);
        }

        [DataTestMethod]
        // Pour parametrer le test et le repeter plusieurs fois,
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(4, 4, 8)]
        [DataRow(5, 0, 5)]
        public void E_TestSomme_NombresPositifs2(int a, int b, int c)
        {
            c.Should().Be(calcul.Somme(a, b));
        }

        [DataTestMethod]
        // Pour alimenter le test avec des valeurs dynamiques
        [DynamicData(nameof(DataSource), DynamicDataSourceType.Method)]
        public void F_TestSomme_NombresPositifs3(int a, int b, int c)
        {
            c.Should().Be(calcul.Somme(a, b));
        }

        [TestMethod]
        [TestCategory("On verifie que la multiplication de 3 et 2 est bien 6")]
        public void I_TestMultiplication_3_2_6()
        {
            using (new AssertionScope())
            {
                Assert.AreEqual(6, calcul.Multiplication(3, 2), "Resultat attendu = 6");
                Assert.AreNotEqual(5, calcul.Multiplication(3, 2));
                Assert.IsTrue(calcul.Multiplication(3, 2) == 6);
                Assert.IsFalse(calcul.Multiplication(3, 2) != 6);
                // Fluent Assertions
                calcul.Multiplication(3, 2).Should().Be(6, "3 * 2 = 6");
                calcul.Multiplication(3, 2).Should().NotBe(7, "3 * 2 = 6");
                calcul.Multiplication(3, 2).Should().BeLessThan(7, "3 * 2 = 6");
            }
        }

        [TestMethod]
        [TestCategory("On verifie que la soustraction de 7 par 3 est bien 4")]
        public void J_TestSoustraction_7_3_4()
        {
            using (new AssertionScope())
            {
                Assert.AreEqual(4, calcul.Soustraction(7, 3), "Resultat attendu = 4");
                Assert.AreNotEqual(5, calcul.Soustraction(7, 3));
                Assert.IsTrue(calcul.Soustraction(7, 3) == 4);
                Assert.IsFalse(calcul.Soustraction(7, 3) != 4);
                // Fluent Assertions
                calcul.Soustraction(7, 3).Should().Be(4, "7 - 3 = 4");
                calcul.Soustraction(7, 3).Should().NotBe(7, "7 - 3 = 4");
                calcul.Soustraction(7, 3).Should().BeLessThan(5, "7 - 3 = 4");
            }
        }

        public static IEnumerable<object[]> DataSource()
        {
            // yeld return retourne chaque element un par un
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 2, 2, 4 };
            yield return new object[] { 3, 3, 6 };
            yield return new object[] { 4, 4, 8 };
            yield return new object[] { 5, 0, 5 };
        }
    }
}
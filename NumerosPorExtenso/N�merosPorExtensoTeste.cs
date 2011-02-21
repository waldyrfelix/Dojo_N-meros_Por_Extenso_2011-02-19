using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Números_Por_Extenso
{
    [TestClass]
    public class NúmerosPorExtensoTeste
    {
        [TestMethod]
        public void Quando_Passo_0_Retorna_Zero()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(0);

            Assert.AreEqual("Zero", resultado);
        }

        [TestMethod]
        public void Quando_Passo_1_Retorna_Um()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(1);

            Assert.AreEqual("Um", resultado);
        }

        [TestMethod]
        public void Quando_Passo_2_Retorna_Dois()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(2);

            Assert.AreEqual("Dois", resultado);
        }

        [TestMethod]
        public void Quando_Passo_3_Retorna_Três()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(3);

            Assert.AreEqual("Três", resultado);
        }

        [TestMethod]
        public void Quando_Passo_4_Retorna_Quatro()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(4);

            Assert.AreEqual("Quatro", resultado);
        }

        [TestMethod]
        public void Quando_Passo_5_Retorna_Cinco()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(5);

            Assert.AreEqual("Cinco", resultado);
        }

        [TestMethod]
        public void Quando_Passo_6_Retorna_Seis()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(6);

            Assert.AreEqual("Seis", resultado);
        }

        [TestMethod]
        public void Quando_Passo_7_Retorna_Sete()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(7);

            Assert.AreEqual("Sete", resultado);
        }

        [TestMethod]
        public void Quando_Passo_8_Retorna_Oito()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(8);

            Assert.AreEqual("Oito", resultado);
        }

        [TestMethod]
        public void Quando_Passo_9_Retorna_Nove()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(9);

            Assert.AreEqual("Nove", resultado);
        }

        [TestMethod]
        public void Quando_Passo_10_Retorna_Dez()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(10);

            Assert.AreEqual("Dez", resultado);
        }

        [TestMethod]
        public void Quando_Passo_11_Retorna_Onze()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(11);

            Assert.AreEqual("Onze", resultado);
        }

        [TestMethod]
        public void Quando_Passo_12_Retorna_Doze()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(12);

            Assert.AreEqual("Doze", resultado);
        }

        [TestMethod]
        public void Quando_Passo_13_Retorna_Treze()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(13);

            Assert.AreEqual("Treze", resultado);
        }

        [TestMethod]
        public void Quando_Passo_14_Retorna_Quatorze()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(14);

            Assert.AreEqual("Quatorze", resultado);
        }

        [TestMethod]
        public void Quando_Passo_15_Retorna_Quinze()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(15);

            Assert.AreEqual("Quinze", resultado);
        }

        [TestMethod]
        public void Quando_Passo_16_Retorna_Dezesseis()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(16);

            Assert.AreEqual("Dezesseis", resultado);
        }

        [TestMethod]
        public void Quando_Passo_17_Retorna_Dezessete()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(17);

            Assert.AreEqual("Dezessete", resultado);
        }

        [TestMethod]
        public void Quando_Passo_18_Retorna_Dezoito()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(18);

            Assert.AreEqual("Dezoito", resultado);
        }

        [TestMethod]
        public void Quando_Passo_19_Retorna_Dezenove()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(19);

            Assert.AreEqual("Dezenove", resultado);
        }

        [TestMethod]
        public void Quando_Passo_20_Retorna_Vinte()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(20);

            Assert.AreEqual("Vinte", resultado);
        }

        [TestMethod]
        public void Quando_Passo_21_Retorna_Vinte_e_Um()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(21);

            Assert.AreEqual("Vinte e Um", resultado);
        }

        [TestMethod]
        public void Quando_Passo_22_Retorna_Vinte_e_Dois()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(22);

            Assert.AreEqual("Vinte e Dois", resultado);
        }

        [TestMethod]
        public void Quando_Passo_30_Retorna_Trinta()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(30);

            Assert.AreEqual("Trinta", resultado);
        }

        [TestMethod]
        public void Quando_Passo_31_Retorna_Trinta_e_Um()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(31);

            Assert.AreEqual("Trinta e Um", resultado);
        }

        [TestMethod]
        public void Quando_Passo_40_Retorna_Quarenta()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(40);

            Assert.AreEqual("Quarenta", resultado);
        }

        [TestMethod]
        public void Quando_Passo_41_Retorna_Quarenta_e_Um()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(41);

            Assert.AreEqual("Quarenta e Um", resultado);
        }

        [TestMethod]
        public void Quando_Passo_50_Retorna_Cinquenta()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(50);

            Assert.AreEqual("Cinquenta", resultado);
        }

        [TestMethod]
        public void Quando_Passo_51_Retorna_Cinquenta_e_Um()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(51);

            Assert.AreEqual("Cinquenta e Um", resultado);
        }

        [TestMethod]
        public void Quando_Passo_60_Retorna_Sessenta()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(60);

            Assert.AreEqual("Sessenta", resultado);
        }

        [TestMethod]
        public void Quando_Passo_61_Retorna_Sessenta_e_Um()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(61);

            Assert.AreEqual("Sessenta e Um", resultado);
        }

        [TestMethod]
        public void Quando_Passo_70_Retorna_Setenta()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(70);

            Assert.AreEqual("Setenta", resultado);
        }

        [TestMethod]
        public void Quando_Passo_100_Retorna_Cem()
        {
            string resultado = ConverteNumeros.converteNumeroParaExtenso(100);

            Assert.AreEqual("Cem", resultado);
        }


        [ExpectedException(typeof (InvalidOperationException))]
        [TestMethod]
        public void Quando_Numero_Negativo_Lanca_InvalidOperationException()
        {
            string retorno = ConverteNumeros.converteNumeroParaExtenso(-1);
        }

        [ExpectedException(typeof (InvalidOperationException))]
        [TestMethod]
        public void Quando_Numero_Maior_Que_100_Lanca_InvalidOperationException()
        {
            string retorno = ConverteNumeros.converteNumeroParaExtenso(101);
        }
    }
}
using Contmatic.Integracao.Domain.ObjetosValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integracao.Domain.Test.Domain.Shared.ObjetosValor
{
    public class EmailTest
    {
        [TestClass]
    public class EmailTeste
    {
        [DataTestMethod]
        [DataRow("testeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee@contmatic.com.br")]
        public void VerificaQuantidadeCaracteres(string endereco)
        {
            //arrange
            Email email;
            //act
            email = Email.Factory(endereco);
            //assert
            Assert.IsTrue(email.Invalido);
        }

        [DataTestMethod]
        //[DataRow("tes*te@contmatic")]//**
        [DataRow("testecontmatic.com.br")]
        [DataRow("teste @contmatic.com")]
        //[DataRow("teste@@contmatic.com.br")]//**
        public void VerificaEmailValido(string endereco)
        {
            //**se tornam validos considerando a nova regex
            //arrange
            Email email;
            //act
            email = Email.Factory(endereco);
            //assert
            Assert.IsTrue(email.Invalido);
        }
    }
    }
}
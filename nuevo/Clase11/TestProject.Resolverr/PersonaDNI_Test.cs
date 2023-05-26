using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestUnitarios.ClassLibrary;

namespace TestProject.Resolver
{
    [TestClass]
    public class PersonaDNI_Test
    {
        /// <summary>
        /// Comprobar que el DNI en formato texto NO pueda tener:
        /// Coma
        /// Letras
        /// Arroja DniInvalidoException
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Texto()
        {
            //Arrange
            string dniComa = "30.999,999";
            string dniTexto = "30a00123";

            //Act y Assert
            try
            {
                Persona personaPrimero = new Persona("Juan", "Lopez", dniComa, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dniComa);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
            //Completar con dniTexto
            try
            {
                Persona personaPrimero = new Persona("Juan", "Lopez", dniTexto, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dniTexto);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

        }

        /// <summary>
        /// Comprobar que el DNI no pueda ser menor a 1
        /// Arroja NacionalidadInvalidaException
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Bajo()
        {
            //Arrange
            string dniUno = "0";
            int dniDos = -1;

            //Act y Assert

            try
            {
                Persona personaUno = new Persona("Kevin", "Veliz", dniDos, ENacionalidad.Argentina);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }

        /// <summary>
        /// Comprobar que el DNI no pueda ser mayor a 99.999.999
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Alto()
        {
            //Arrange
            string dniString = "999999999";

            //Act y Assert
            try
            {
                Persona personaUno = new Persona("Kevin", "Veliz", dniString, ENacionalidad.Argentina);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        /// <summary>
        /// Comprobar los rangos de DNI para Argentinos
        /// </summary>
        [TestMethod]
        public void DNI_Validos_Argentino()
        {
            //Arrange
            int dniPrimero = 1;
            int dniMedio = new Random().Next(1, 89999999);
            int dniUltimo = 89999999;
            string dniString = "89.999.999";

            //Act y Assert
            Persona personaPrimero = new Persona("Juan", "Lopez", dniPrimero, ENacionalidad.Argentina);
            Assert.AreEqual(personaPrimero.DNI, dniPrimero);
            //Completar con dniMedio, dniUltimo y dniString

            //Act y Assert 
            Persona PersonaMedio = new Persona("Kevin", "Veliz", dniMedio, ENacionalidad.Argentina);
            Assert.AreEqual(PersonaMedio.DNI, dniMedio);

        }

        /// <summary>
        /// Comprobar los rangos de DNI para Extranjeros
        /// </summary>
        [TestMethod]
        public void DNI_Validos_Extranjeros()
        {
            //Arrange
            string dniUno = "999999999";
            string dnDos = "-23";

            //Act y Assert

            try
            {
                Persona personaUno = new Persona("Kevin", "Veliz", dniUno, ENacionalidad.Extranjera);
                Persona personaDos = new Persona("Kevin", "Veliz", dnDos, ENacionalidad.Extranjera);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Exception));
            }
        }
    }
}


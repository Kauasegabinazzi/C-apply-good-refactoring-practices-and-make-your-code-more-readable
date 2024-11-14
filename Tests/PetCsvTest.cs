using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NUnit.Framework;
using Alura.Adopet.Console;

namespace Tests
{
    public class PetCsvTest
    {
        [Fact]
        public void ReturnPet()
        {
            //Arrange
            string row = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";

            //Act

            Pet pet = row.ConvertString();

            //Asset

            NUnit.Framework.Legacy.ClassicAssert.NotNull(pet);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Alura.Adopet.Console;
using Xunit;

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

        [Fact]
        public void WhenNull()
        {
            string? row = null;

            NUnit.Framework.Legacy.ClassicAssert.Throws<ArgumentNullException>(() => row.ConvertString());
        }

        [Fact]
        public void WhenStringEmpty()
        {
            string? row = string.Empty;

            NUnit.Framework.Legacy.ClassicAssert.Throws<ArgumentException>(() => row.ConvertString());
        }

        [Fact]
        public void WhenInsufficient()
        {
            string? row = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão";

            NUnit.Framework.Legacy.ClassicAssert.Throws<ArgumentException>(() => row.ConvertString());
        }

        [Fact]
        public void WhenInvalid()
        {
            string? row = "hfjdhdsj1;Lima Limão;1";

            NUnit.Framework.Legacy.ClassicAssert.Throws<ArgumentException>(() => row.ConvertString());
        }

        [Fact]
        public void WhenTypeInvalid()
        {
            string? row = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão; 2";

            NUnit.Framework.Legacy.ClassicAssert.Throws<ArgumentException>(() => row.ConvertString());
        }

    }
}

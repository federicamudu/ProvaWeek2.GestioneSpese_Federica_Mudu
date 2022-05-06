using ProvaWeek2.GestioneSpese.Presentation;
using ProvaWeek2.GestioneSpese.Presentation.Factory;
using Xunit;

namespace TestProjectSpese
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldApproved()
        {
            //ARRANGE
            double importo = 500;
            string categoria = "Viaggio";
            FactoryRimborso factory = new FactoryRimborso();

            //act
            IImportoRimborsato importoRimborsato = factory.GetImporto(categoria);

            //Assert

            //Assert.Equal(550, );

        }
    }
}
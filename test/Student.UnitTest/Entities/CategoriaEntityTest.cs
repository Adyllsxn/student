namespace Student.UnitTest.Entities;
public class CategoriaEntityTest
{
    #region </Constants>
        private const int InvalidNumberZero = 0;
        private const int InvalidNumber = -1;
        private const string ValidName = "Test0";
    #endregion

    #region </Id>
        [Theory]
        [InlineData(InvalidNumber, ValidName)]
        [InlineData(InvalidNumberZero, ValidName)]
        public void Categoria_ShouldFailIdIfIdIsNegative(int id, string nome)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new CategoriaEntity(id, nome);
            });
        }
    #endregion

    #region </Nome>
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void Categoria_ShouldFailIfNameIsNullOrEmptyOrWhiteSpace(string nome)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new CategoriaEntity(nome);
            });
        }
    #endregion

    #region </LongLenght>
        [Fact]
        public void Categoria_ShouldFailIfIsHaveLongLenght()
        {
            var LongLenght = new string('B', 51);
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new CategoriaEntity(LongLenght);
            });
        }
    #endregion

    #region </Criar>
        [Theory]
        [InlineData(ValidName)]
        public void Categoria_ShouldCreate(string nome)
        {
            var count = new CategoriaEntity(nome);
            Assert.NotNull(count);
        }
    #endregion

    #region </Editar>
        [Theory]
        [InlineData(ValidName)]
        public void Categoria_ShouldEdit(string nome)
        {
            var count = new CategoriaEntity(nome);
            count.Update("Test");
            Assert.Equal("Test", count.Nome);
        }
    #endregion

}

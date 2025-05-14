namespace Student.UnitTest.Entities;
public class TipoUsuarioEntityTest
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
        public void TipoUsuario_ShouldFailIdIfIdIsNegative(int id, string nome)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new TipoUsuarioEntity(id, nome);
            });
        }
    #endregion

    #region </Nome>
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void TipoUsuario_ShouldFailIfNameIsNullOrEmptyOrWhiteSpace(string nome)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new TipoUsuarioEntity(nome);
            });
        }
    #endregion

    #region </LongLenght>
        [Fact]
        public void TipoUsuario_ShouldFailIfIsHaveLongLenght()
        {
            var LongLenght = new string('B', 51);
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new TipoUsuarioEntity(LongLenght);
            });
        }
    #endregion

    #region </Criar>
        [Theory]
        [InlineData(ValidName)]
        public void TipoUsuario_ShouldCreate(string nome)
        {
            var count = new TipoUsuarioEntity(nome);
            Assert.NotNull(count);
        }
    #endregion
}

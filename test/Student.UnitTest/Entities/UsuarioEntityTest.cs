namespace Student.UnitTest.Entities;
public class UsuarioEntityTest
{
    #region </Constants>
        private const int InvalidNumberZero = 0;
        private const int InvalidNumber = -1;
        private const string ValidName = "Test";
        private const string ValidEmail = "Test@test.com";
        private const int ValidTipoUsuario = 1;
    #endregion

    #region </Id>
        [Theory]
        [InlineData(InvalidNumber, ValidName, ValidEmail, ValidTipoUsuario)]
        [InlineData(InvalidNumberZero, ValidName, ValidEmail, ValidTipoUsuario)]
        public void Usuario_ShouldFailIfIdIdIsNegative(int id, string nome, string email, int tipoUsuarioId)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new UsuarioEntity(id, nome, email, tipoUsuarioId);
            });
        }
    #endregion

    #region </Nome>
        [Theory]
        [InlineData("", ValidEmail, ValidTipoUsuario)]
        [InlineData(null, ValidEmail, ValidTipoUsuario)]
        [InlineData(" ", ValidEmail, ValidTipoUsuario)]
        public void Usuario_ShouldFailIfNameIsNullOrEmptyOrWhiteSpace(string nome, string email, int tipoUsuarioId)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new UsuarioEntity(nome, email, tipoUsuarioId);
            });
        }
    #endregion

    #region </Email>
        [Theory]
        [InlineData(ValidName, "", ValidTipoUsuario)]
        [InlineData(null, null, ValidTipoUsuario)]
        [InlineData(ValidName, " ", ValidTipoUsuario)]
        public void Usuario_ShouldFailIfEmailIsNullOrEmptyOrWhiteSpace(string nome, string email, int tipoUsuarioId)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new UsuarioEntity(nome, email, tipoUsuarioId);
            });
        }
    #endregion

    #region <LongLenght>
        [Fact]
        public void Usuario_ShouldFailIfIsHaveLongLenght()
        {
            var LongLenght = new string('B', 251);
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new UsuarioEntity(LongLenght, LongLenght, ValidTipoUsuario);
            });
        }
    #endregion

    #region <Criar>
        [Theory]
        [InlineData(ValidName, ValidEmail, ValidTipoUsuario)]
        public void Usuario_ShouldCreate(string nome, string email, int tipoUsuarioId)
        {
            var count = new UsuarioEntity(nome, email, tipoUsuarioId);
            Assert.NotNull(count);
        }
    #endregion

}

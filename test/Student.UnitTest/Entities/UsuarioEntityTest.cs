namespace Student.UnitTest.Entities;
public class UsuarioEntityTest
{
    #region </Constants>
        private const int InvalidNumberZero = 0;
        private const int InvalidNumber = -1;
        private const string ValidName = "Test";
        private const string ValidEmail = "Test@test.com";
        private const bool ValidIsAdmin = true;
    #endregion

    #region </Id>
        [Theory]
        [InlineData(InvalidNumber, ValidName, ValidEmail)]
        [InlineData(InvalidNumberZero, ValidName, ValidEmail)]
        public void Usuario_ShouldFailIfIdIdIsNegative(int id, string nome, string email)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new UsuarioEntity(id, nome, email);
            });
        }
    #endregion

    #region </Nome>
        [Theory]
        [InlineData("", ValidEmail)]
        [InlineData(null, ValidEmail)]
        [InlineData(" ", ValidEmail)]
        public void Usuario_ShouldFailIfNameIsNullOrEmptyOrWhiteSpace(string nome, string email)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new UsuarioEntity(nome, email);
            });
        }
    #endregion

    #region </Email>
        [Theory]
        [InlineData(ValidName, "")]
        [InlineData(null, null)]
        [InlineData(ValidName, " ")]
        public void Usuario_ShouldFailIfEmailIsNullOrEmptyOrWhiteSpace(string nome, string email)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new UsuarioEntity(nome, email);
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
                var acount = new UsuarioEntity(LongLenght, LongLenght);
            });
        }
    #endregion

    #region <Criar>
        [Theory]
        [InlineData(ValidName, ValidEmail)]
        public void Usuario_ShouldCreate(string nome, string email)
        {
            var count = new UsuarioEntity(nome, email);
            Assert.NotNull(count);
        }
    #endregion

}

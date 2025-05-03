namespace Student.UnitTest.Entities;
public class PostagemEntityTest
{
    #region </Constants>
        private const int InvalidNumberZero = 0;
        private const int InvalidNumber = -1;
        private const string ValidTitulo = "Test";
        private const string ValidImagem = "Test@test.com";
        private const int ValidCategoria = 1;
    #endregion

    #region </Id>
        [Theory]
        [InlineData(InvalidNumber, ValidTitulo, "1999-01-01", ValidImagem, ValidCategoria)]
        [InlineData(InvalidNumberZero, ValidTitulo, "1999-01-01", ValidImagem, ValidCategoria)]
        public void Postagem_ShouldFailIfIdIdIsNegative(int id, string titulo, DateTime data, string imagem, int categoriaId)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new PostagemEntity(id, titulo, data, imagem, categoriaId);
            });
        }
    #endregion

    #region </Nome>
        [Theory]
        [InlineData("", "1999-01-01", ValidImagem, ValidCategoria)]
        [InlineData(null, "1999-01-01", ValidImagem, ValidCategoria)]
        [InlineData(" ", "1999-01-01", ValidImagem, ValidCategoria)]
        public void Postagem_ShouldFailIfTituloIsNullOrEmptyOrWhiteSpace(string titulo, DateTime data, string imagem, int categoriaId)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new PostagemEntity(titulo, data, imagem, categoriaId);
            });
        }
    #endregion

    #region </Imagem>
        [Theory]
        [InlineData(ValidTitulo, "1999-01-01", "", ValidCategoria)]
        [InlineData(ValidTitulo, "1999-01-01", null, ValidCategoria)]
        [InlineData(ValidTitulo, "1999-01-01", " ", ValidCategoria)]
        public void Postagem_ShouldFailIfImagemIsNullOrEmptyOrWhiteSpace(string titulo, DateTime data, string imagem, int categoriaId)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new PostagemEntity(titulo, data, imagem, categoriaId);
            });
        }
    #endregion

    #region </Categoria>
        [Theory]
        [InlineData(ValidTitulo, "1999-01-01", ValidImagem, InvalidNumber)]
        [InlineData(ValidTitulo, "1999-01-01", ValidImagem, InvalidNumberZero)]
        public void Postagem_ShouldFailIfCategoriaIdIsNagative(string titulo, DateTime data, string imagem, int categoriaId)
        {
            Assert.True(true); 
            Assert.Throws<DomainValidationException>(() =>
            {
                var acount = new PostagemEntity(titulo, data, imagem, categoriaId);
            });
        }
    #endregion

    #region </Criar>
        [Theory]
        [InlineData(ValidTitulo, "1999-01-01", ValidImagem, ValidCategoria)]
        public void Postagem_ShouldCreate(string titulo, DateTime data, string imagem, int categoriaId)
        {
            var count = new PostagemEntity(titulo, data, imagem, categoriaId);
            Assert.NotNull(count);
        }
    #endregion

}
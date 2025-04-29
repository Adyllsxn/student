namespace Student.Presentation.Features.Postagem.Controller;
[ApiController]
[Route("v1/")]
public class PostagensController(IPostagemService service) : ControllerBase
{

    #region </GetAll>
        [HttpGet("Postagens"), EndpointSummary("Obter Postagens")]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetPostagensCommand command,CancellationToken token)
        {
            var response = await service.GetHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </GetById>
        [HttpGet("PostagemById"), EndpointSummary("Obter Postagem Pelo Id")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetPostagemByIdCommand command, CancellationToken token)
        {
            var response = await service.GetByIdHandler(command,token);
            return Ok(response);
        }
    #endregion

    #region </GetFile>
        [HttpGet("PostagemFile"), EndpointSummary("Obter a imagem da postagem Pelo Id")]
        public async Task<IActionResult> GetFileAsync([FromQuery] GetFilePostagemCommand command, CancellationToken token)
        {
            try{
                var response = await service.GetFileHandler(command,token);
                var databyte = System.IO.File.ReadAllBytes(response.Data.Imagem);
                return File(databyte, "image/jpg");
            }
            catch{
                return Problem("Erro ao obter a imagem!");
            }
        }
    #endregion

    #region </Search>
        [HttpGet("SearchPostagem"), EndpointSummary("Pesquisar Postagem")]
        public async Task<IActionResult> SearchAsync([FromQuery] SearchPostagemCommand command, CancellationToken token)
        {
            var response = await service.SearchHendler(command,token);
            return Ok(response);
        }
    #endregion

    #region </Create>
        [HttpPost("CreatePostagem"), EndpointSummary("Criar Postagem")]
        public async Task<IActionResult> CreateAsync([FromForm] PostagemModel model, CancellationToken token)
        {
            if (model.Imagem == null || model.Imagem.Length == 0)
            {
                return BadRequest("Nenhuma imagem foi enviada.");
            }

            string pastaRaiz = "Storage";
            string pastaImagens = Path.Combine(pastaRaiz, "Images");
            if (!Directory.Exists(pastaImagens))
            {
                Directory.CreateDirectory(pastaImagens);
            }

            var extensao = Path.GetExtension(model.Imagem.FileName).ToLower();
            var extensoesPermitidas = new HashSet<string> { ".jpg", ".jpeg", ".png", ".gif" };
            if (!extensoesPermitidas.Contains(extensao))
            {
                return BadRequest($"Extensão de arquivo não suportada: {extensao}. Permitidos: JPG, JPEG, PNG, GIF.");
            }

            string nomeArquivo = $"{Guid.NewGuid()}{extensao}";
            string caminhoCompleto = Path.Combine(pastaImagens, nomeArquivo);

            await using var stream = new FileStream(caminhoCompleto, FileMode.Create);
            await model.Imagem.CopyToAsync(stream);

            var newCommand = new CreatePostagemCommand{
                Titulo = model.Titulo,
                Imagem = caminhoCompleto,
                CategoriaId = model.CategoriaId
            };
            var response = await service.CreateHandler(newCommand,token);
            return Ok(response);
        }
    #endregion

    #region </Delete>
        [HttpDelete("DeletePostagem"), EndpointSummary("Excluir Postagem")]
        public async Task<IActionResult> DeleteAsync(DeletePostagemCommand command, CancellationToken token)
        {
            var delete = new GetPostagemByIdCommand{Id = command.Id};
            var result = await service.GetByIdHandler(delete, token);
            if (!string.IsNullOrEmpty(result.Data?.Imagem) && System.IO.File.Exists(result.Data.Imagem))
            {
                System.IO.File.Delete(result.Data.Imagem);
            }

            var response = await service.DeleteHandler(command,token);
            return Ok(response);
        }
    #endregion

}

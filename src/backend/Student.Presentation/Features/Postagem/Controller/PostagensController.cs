namespace Student.Presentation.Features.Postagem.Controller;
[ApiController]
[Route("v1/")]
[Authorize]
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
                if(response.Data?.Imagem == null)
                {
                    return BadRequest("Imagem não encontrada");
                }
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
        public async Task<IActionResult> CreateAsync([FromForm] CreatePostagemModel model, CancellationToken token)
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

    #region </Update>
        [HttpPut("UpdatePostagem"), EndpointSummary("Editar Postagem")]
        public async Task<IActionResult> UpdateAsync([FromForm] UpdatePostagemModel model, CancellationToken token)
        {
            var getCommand = new GetPostagemByIdCommand { Id = model.Id };
            var result = await service.GetByIdHandler(getCommand, token);

            if (result.Data is null)
                return NotFound("Postagem não encontrada.");

            string caminhoAntigo = result.Data.Imagem;
            string caminhoNovo = caminhoAntigo;

            if (model.Imagem != null && model.Imagem.Length > 0)
            {
                var extensao = Path.GetExtension(model.Imagem.FileName).ToLower();
                var extensoesPermitidas = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                if (!extensoesPermitidas.Contains(extensao))
                    return BadRequest("Extensão de imagem inválida. Use JPG, JPEG, PNG ou GIF.");

                string pasta = Path.Combine("Storage", "Images");
                Directory.CreateDirectory(pasta);

                string novoNome = $"{Guid.NewGuid()}{extensao}";
                caminhoNovo = Path.Combine(pasta, novoNome);

                await using var stream = new FileStream(caminhoNovo, FileMode.Create);
                await model.Imagem.CopyToAsync(stream);

                if (System.IO.File.Exists(caminhoAntigo))
                    System.IO.File.Delete(caminhoAntigo);
            }

            var command = new UpdatePostagemCommand
            {
                Id = model.Id,
                Titulo = model.Titulo,
                CategoriaId = model.CategoriaId,
                Imagem = caminhoNovo
            };

            var response = await service.UpdateHendler(command, token);
            return Ok(response);
        }

    #endregion

}
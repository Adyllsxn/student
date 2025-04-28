namespace Student.Presentation.Features.Postagem.Controller;
[ApiController]
[Route("v1/")]
public class PostagensController(IPostagemService service) : ControllerBase
{
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
}

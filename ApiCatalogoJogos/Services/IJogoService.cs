using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Services
{
    public interface IJogoService
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade); // Lista de jogos
        Task<JogoViewModel> Obter(Guid id); // Jogos por ID
        Task<JogoViewModel> Inserir(JogoInputModel jogo); 
        Task Atualizar(Guid id, JogoInputModel jogo); // Atualizar tudo
        Task Atualizar(Guid id, double preco); // Atualizar preço por ID
        Task Remover(Guid id); // Remover por ID
    }
}
